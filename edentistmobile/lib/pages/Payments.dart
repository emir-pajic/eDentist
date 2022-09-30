import 'package:edentistmobile/models/Appointment.dart';
import 'package:edentistmobile/models/Examination.dart';
import 'package:flutter/material.dart';
import 'package:edentistmobile/services/APIService.dart';

import 'PaymentDetails.dart';

class Payments extends StatefulWidget {
  const Payments({Key? key}) : super(key: key);

  @override
  State<Payments> createState() => _PaymentsState();
}

class _PaymentsState extends State<Payments> {

  var welcomeName =
      "${APIService.signedInUser!.firstName!} ${APIService.signedInUser!.lastname!} payments";
  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: const BoxDecoration(
          image: DecorationImage(
              image: AssetImage('assets/bg.png'), fit: BoxFit.cover)),
      child: Scaffold(
        backgroundColor: Colors.transparent,
        appBar: AppBar(
          title: Text(welcomeName),
          backgroundColor: Colors.blue[900],

        ),
        body: bodyWidget(),
      ),
    );
  }

  Widget bodyWidget() {
    return FutureBuilder<List<Examination>>(
      future: getMyExaminations(APIService.signedInUser?.userId ?? 0),
      builder:
          (BuildContext context, AsyncSnapshot<List<Examination>> snapshot) {
        if (snapshot.connectionState==ConnectionState.waiting){
          return Center(child: Text("Loading...."),);
        }else if (snapshot.hasError){
          return Center(child: Text("Error...."),);

        }
        else{
          return ListView(
            //children: snapshot.data.map((e) => AppointmentWidget(e)),
            children: snapshot.data!.map((e) => ExaminationtWidget(e)).toList(),
          );
        }
      },
    );
  }

  Future<List<Examination>> getMyExaminations(int userId) async{
    var examinations = await APIService.getmypaidexaminations("Examinations", userId);


    return examinations;

  }

  Widget ExaminationtWidget(examination){

    // get doctor's ID (accBy) and write name and lastname
    return Padding(
      padding: EdgeInsets.fromLTRB(2, 2, 2, 2),
      child: Card(
        child: TextButton(
          onPressed: (){
            Navigator.push(context, MaterialPageRoute(builder: (context) => PaymentDetails(examination: examination)));

          },
          child: Padding(
              padding: EdgeInsets.all(20),
              // ignore: prefer_interpolation_to_compose_strings
              child: Text("Treatment: " + examination.treatmentDesription + " |  Price: " + examination.price.toInt().toString() + " €")),
        ),
      ),
    );
  }
}
