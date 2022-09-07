import 'package:edentistmobile/models/Appointment.dart';
import 'package:flutter/material.dart';
import 'package:edentistmobile/services/APIService.dart';

class MyAppointments extends StatefulWidget {
  @override
  _MyAppointmentsState createState() => _MyAppointmentsState();


}

class _MyAppointmentsState extends State<MyAppointments> {

  var welcomeName = "${APIService.signedInUser!.firstName!} ${APIService.signedInUser!.lastname!} appointments";





  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: const BoxDecoration(
          image: DecorationImage(
              image: AssetImage('assets/bg.png'),
              fit: BoxFit.cover)),
      child: Scaffold(
        backgroundColor: Colors.transparent,
        appBar: AppBar(
          title: Text(welcomeName),
          backgroundColor: Colors.blue[900],
        ),


      ),
    );
  }



}