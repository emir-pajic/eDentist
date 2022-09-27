
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';

import '../models/Appointment.dart';
import '../models/User.dart';

class AppointmentDetails extends StatelessWidget {
  final Appointment? appointment;


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
              subtitle: Text("Status: ${appointment?.appointmentStatus}"),

            ),
            Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: <Widget>[

                const SizedBox(width: 8),

              ],
            ),
          ],
        ),
      ),
    );
  }

}



