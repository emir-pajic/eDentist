import 'dart:convert';
import 'package:edentistmobile/models/Appointment.dart';
import 'package:edentistmobile/models/Examination.dart';
import 'package:edentistmobile/models/Treatment.dart';
import 'package:http/http.dart' as http;
import 'dart:io';

import '../models/User.dart';

class APIService {
  static String? username;
  static String? password;
  static User? signedInUser;

  static String apiAddress = "10.0.2.2";
  static int apiPort = 5000;
  static String apiBase = "http://$apiAddress:$apiPort/api/";

  String route;

  APIService({required this.route});

  void SetParameter(String Username, String Password) {
    username = Username;
    password = Password;
  }

  static Future<dynamic> authenticate(String route, String body) async {
    String baseUrl = '$apiBase$route';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
      body: body,
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> getmyappointments(String route, int userId) async {
    String baseUrl = '$apiBase$route';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    List<Appointment> myappointments = <Appointment>[];

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      List<Appointment> appointments = (json.decode(response.body) as List)
          .map((data) => Appointment.fromJson(data))
          .toList();

      appointments.forEach((item) {
        if (item.userId == APIService.signedInUser?.userId) {
          myappointments.add(item);
        }
      });

      return myappointments.toList();
    }
    return null;
  }

  static Future<dynamic> getDoctor(String route, int? userId) async {
    String baseUrl = '$apiBase$route$userId';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> removeAppointment(String route, int? appId) async {
    String baseUrl = '$apiBase$route$appId';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.delete(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Accept': 'text/plain',
        HttpHeaders.authorizationHeader: basicAuth
      },
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      print(response.body);
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> bookAppointment(String route, String body) async {
    String baseUrl = '$apiBase$route';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
      body: body,
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> getmyexaminations(String route, int userId) async {
    String baseUrl = '$apiBase$route';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    List<Examination> myExaminations = <Examination>[];

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      List<Examination> examinations = (json.decode(response.body) as List)
          .map((data) => Examination.fromJson(data))
          .toList();

      var apps = await getmyappointments("Appointments", userId);
      var trtmt = await getTreatments("Treatments") as List;
      var trM = trtmt.map((data) => Treatment.fromJson(data))
          .toList();



      examinations.forEach((item) {
        apps.forEach((appointment) {

            if (item.appointmentId == appointment.appointmentId && appointment.userId == userId){
              item.exDate = appointment.date;
             myExaminations.add(item);
            }

          });
      });

      myExaminations.forEach((ex) {
        trM.forEach((tr) {

          if (tr.treatmentId == ex.treatmentId){
            ex.treatmentDesription = tr.description;
            ex.price = tr.price;
          }

        });
      });

      return myExaminations.toList();
    }
    return null;
  }

  static Future<dynamic> getTreatments(String route) async {
    String baseUrl = '$apiBase$route';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.get(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth
      },
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

  static Future<dynamic> updateExamination(String route, int? exId, String body) async {
    String baseUrl = '$apiBase$route$exId';
    final String basicAuth =
        'Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.put(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader: basicAuth,
        'ID': '${exId}'
      },
      body: body,
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }

}
