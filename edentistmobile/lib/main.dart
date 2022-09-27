
import 'package:edentistmobile/pages/BookAppointments.dart';
import 'package:edentistmobile/pages/Home.dart';
import 'package:edentistmobile/pages/MyExaminations.dart';
import 'package:flutter/material.dart';
import 'package:edentistmobile/pages/Login.dart';
import 'package:edentistmobile/pages/MyAppointments.dart';




void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home:Login(),
      routes: {
        '/login':(context)=>Login(),
        '/bookAppointment':(context)=>BookAppointment(),
        '/home':(context)=>Home(),
        //'/appointments':(context)=>Appointments(),
        '/myAppointments':(context)=>MyAppointments(),
        '/myExaminations':(context)=>MyExaminations(),
        //'/ocjene':(context)=>MojeOcjene()
      },
    );
  }
}