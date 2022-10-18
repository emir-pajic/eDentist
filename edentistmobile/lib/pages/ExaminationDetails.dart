import 'dart:convert';
import 'package:uuid/uuid.dart';

import 'package:edentistmobile/controller/payment_controller.dart';
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../models/Examination.dart';

class ExaminationDetails extends StatelessWidget {
  final Examination? examination;

  const ExaminationDetails({Key? key, required this.examination}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final paymentController = Get.put(PaymentController());

    return Scaffold(
      backgroundColor: Colors.transparent,
      appBar: AppBar(
        title: const Text("Examination Details"),
        backgroundColor: Colors.blue[900],
      ),
      body: Card(
        child: Column(
          children: <Widget>[
            ListTile(
              leading: const Icon(Icons.face),
              title: Text("Examination: ${examination?.additionalInfo}", style: const TextStyle(
                  fontSize: 24,
                  color: Colors.black,
                  fontWeight: FontWeight.w400
              ),),
              subtitle: Text(
                  "\nTreatment: ${examination?.treatmentDesription}\n\nStatus: ${examination?.status}\n\nPrice: ${examination?.price!.toInt().toString()} €\n\n", style: const TextStyle(
                  fontSize: 22,
                  color: Colors.blue
              ),),

            ),
            Center(
              child: ElevatedButton(

                  child: const Text("Make Payment", style: TextStyle(
                    fontSize: 24,
                    fontStyle: FontStyle.italic,
                    letterSpacing: 1.5
                  ),),


                  onPressed: () async {
                    if (examination?.paymentTokenId.isNull == true) {
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
                        'paymentTokenId': Uuid().v1()
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
