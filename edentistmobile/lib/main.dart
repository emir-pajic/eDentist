
import 'package:edentistmobile/pages/BookAppointments.dart';
import 'package:edentistmobile/pages/Home.dart';
import 'package:edentistmobile/pages/MyExaminations.dart';
import 'package:flutter/material.dart';
import 'package:edentistmobile/pages/Login.dart';
import 'package:edentistmobile/pages/MyAppointments.dart';
import 'package:flutter_stripe/flutter_stripe.dart';
import 'package:edentistmobile/pages/Payments.dart';



void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  Stripe.publishableKey = 'pk_test_51LmyUKEOfTcAasxeJukjP2cLq7z23OEigceGmHtErpAI654wz0iGm3w0Ax9OaIag1lKg9tC42mITbt624AOQravT00BkYUpYEV';

  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home:const Login(),
      routes: {
        '/login':(context)=>const Login(),
        '/bookAppointment':(context)=>const BookAppointment(),
        '/home':(context)=>Home(),
        '/myAppointments':(context)=>MyAppointments(),
        '/myExaminations':(context)=>const MyExaminations(),
        '/payments':(context)=>const Payments()
      },
    );
  }
}