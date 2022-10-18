import 'dart:convert';
import 'package:uuid/uuid.dart';

import 'package:edentistmobile/controller/payment_controller.dart';
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../models/Examination.dart';

class PaymentDetails extends StatelessWidget {
  final Examination? examination;

  PaymentDetails({Key? key, required this.examination}) : super(key: key);

  @override
  Widget build(BuildContext context) {

    return Scaffold(
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        title: Text("Payment Details"),
        backgroundColor: Colors.blue[900],
      ),
      body: Card(
        child: Column(
          children: <Widget>[
            ListTile(
              leading: const Icon(Icons.monetization_on_sharp),
              title: Text("Subject: Payment for treatment ${examination?.treatmentDesription}", style: const TextStyle(
                fontSize: 24
              ),),
              subtitle: Text(
                  "\nRef number: ${examination?.paymentTokenId}\n\nCard Number: **** **** **** 4242\n\nReceiver: eDentist d.o.o Mostar \n\nStatus: Completed\n\nAmount: ${examination?.price?.toInt()} €", style: const TextStyle(
                fontSize: 18,
                fontStyle: FontStyle.italic,
                color: Colors.blue
              ),),
            ),


          ],
        ),
      ),
    );
  }
}
