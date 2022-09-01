
import 'package:flutter/material.dart';
import 'package:edentistmobile/pages/Login.dart';



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
        //'/loading':(context)=>Loading(),
        //'/home':(context)=>Home(),
        //'/appointments':(context)=>Appointments(),
        //'/myAppointments':(context)=>MyAppointments(),
        //'/examinations':(context)=>Examinations(),
        //'/ocjene':(context)=>MojeOcjene()
      },
    );
  }
}