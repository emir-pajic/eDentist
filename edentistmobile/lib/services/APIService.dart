import 'dart:convert';
import 'package:http/http.dart' as http;
import 'dart:io';

import '../models/User.dart';

class APIService{
  static String? username;
  static String? password;
  static User? signedInUser;

  static String apiAddress = "10.0.2.2";
  static int apiPort = 5000;
  static String apiBase = "http://$apiAddress:$apiPort/api/";

  String route;

  APIService({required this.route});

  void SetParameter(String Username, String Password){
    username=Username;
    password=Password;
  }
  static Future<dynamic> authenticate(String route, String body) async {
    String baseUrl='$apiBase$route';
    final String basicAuth='Basic ${base64Encode(utf8.encode('$username:$password'))}';

    print(baseUrl);

    final response = await http.post(
      Uri.parse(baseUrl),
      headers: <String, String>{
        'Content-Type': 'application/json; charset=UTF-8',
        HttpHeaders.authorizationHeader:basicAuth
      },
      body: body,
    );

    if (response.statusCode == 201 || response.statusCode == 200) {
      return json.decode(response.body);
    }
    return null;
  }




}