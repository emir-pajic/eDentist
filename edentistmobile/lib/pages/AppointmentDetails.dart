
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';

import '../models/Appointment.dart';
import '../models/User.dart';

class AppointmentDetails extends StatelessWidget {
  final Appointment? appointment;
  String? doctorName;
  String? doctorLastName;

  AppointmentDetails({Key? key, required this.appointment}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text("Appointment Details"),
      ),
      body: Card(
        child: Column(
          children: <Widget>[
            ListTile(
              leading: Icon(Icons.calendar_month_sharp),
              title: Text("Appointment date: ${appointment?.date}"),
              subtitle: Text("Doctor: ${doctorName}" ),

            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: <Widget>[

                const SizedBox(width: 8),
                TextButton(
                  child: const Text('CANEL APPOINTMENT'),
                  onPressed: () {/* ... */},
                ),
                const SizedBox(width: 8),
              ],
            ),
          ],
        ),
      ),
    );
  }



  Future<User?> getDoctor() async{
    var result = await APIService.getDoctor("User/", appointment?.acceptedById);

    if (result != null){
      return User.fromJson(result);
    }
    return null;
  }
}

