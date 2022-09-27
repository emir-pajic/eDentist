
import 'package:edentistmobile/services/APIService.dart';
import 'package:flutter/material.dart';

import '../models/Examination.dart';

class ExaminationDetails extends StatelessWidget {
  final Examination? examination;


  ExaminationDetails({Key? key, required this.examination}) : super(key: key);

  @override
  Widget build(BuildContext context) {
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
              subtitle: Text("Status: ${examination?.status}"),
              trailing: Text("1000\$"),
            ),
          ],
        ),
      ),
    );
  }

}



