
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';

import '../models/Appointment.dart';

class AppointmentDetails extends StatelessWidget {
  final Appointment? appointment;


  const AppointmentDetails({Key? key, required this.appointment}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        title: const Text("Appointment Details"),
        backgroundColor: Colors.blue[900],

      ),
      body: Card(
        child: Column(
          children: <Widget>[
            ListTile(
              leading: const Icon(Icons.calendar_month_sharp),
              title: Text("Appointment date: ${appointment?.date}", style: const TextStyle(
                fontSize: 24,
                fontStyle: FontStyle.italic,
                color: Colors.blue
              ),),
              subtitle: Text("\nAppointment Status: ${appointment?.appointmentStatus}\n\nLocation: eDentist Office Mostar bb 88400\n\nPatient: ${APIService.signedInUser?.firstName} ${APIService.signedInUser?.lastname}\n\nDoctor: ${appointment?.doctor ?? "N/A"}", style: const TextStyle(
                fontSize: 22,
                color: Colors.blue,
                fontStyle: FontStyle.italic
              )),
            ),

          ],
        ),
      ),
    );
  }

}



