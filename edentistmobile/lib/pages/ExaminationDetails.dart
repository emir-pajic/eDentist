import 'dart:convert';

import 'package:edentistmobile/controller/payment_controller.dart';
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../models/Examination.dart';

class ExaminationDetails extends StatelessWidget {
  final Examination? examination;

  ExaminationDetails({Key? key, required this.examination}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final paymentController = Get.put(PaymentController());

    return Scaffold(
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        title: Text("Examination Details"),
        backgroundColor: Colors.blue[900],
      ),
      body: Card(
        child: Column(
          children: <Widget>[
            ListTile(
              leading: Icon(Icons.face),
              title: Text("Examination: ${examination?.additionalInfo}"),
              subtitle: Text(
                  "Treatment: ${examination?.treatmentDesription}\nStatus: ${examination?.status}"),
              trailing: Text("${examination?.price!.toInt().toString()} €"),
            ),
            Center(
              child: ElevatedButton(
                  child: Text("Make Payment"),
                  onPressed: () async {
                    if (examination?.paymentTokenId != 'payment') {
                      paymentController.makePayment(
                          amount: '${examination?.price!.toInt()}',
                          currency: 'EUR');
                      Map data = {
                        'examinationId': examination?.examinationId,
                        'additionalInfo': examination?.additionalInfo,
                        'appointmentId': examination?.appointmentId,
                        'userId': examination?.userId,
                        'treatmentId': examination?.treatmentId,
                        'status': examination?.status,
                        'paymentTokenId': 'payment'
                      };

                      var body = jsonEncode(data);

                      await APIService.updateExamination(
                          "Examinations/", examination?.examinationId, body);
                    } else {
                      var error = 'This examination is already paid';
                      ScaffoldMessenger.of(context).showSnackBar(SnackBar(
                        content: SizedBox(
                            height: 40, child: Center(child: Text(error))),
                        backgroundColor: Colors.orange,
                      ));
                    }
                  }),
            )
          ],
        ),
      ),
    );
  }
}
