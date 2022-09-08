import 'package:edentistmobile/models/Appointment.dart';
import 'package:flutter/material.dart';
import 'package:edentistmobile/services/APIService.dart';

import 'AppointmentDetails.dart';

class MyAppointments extends StatefulWidget {
  @override
  _MyAppointmentsState createState() => _MyAppointmentsState();
}

class _MyAppointmentsState extends State<MyAppointments> {
  var welcomeName =
      "${APIService.signedInUser!.firstName!} ${APIService.signedInUser!.lastname!} appointments";

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
    return FutureBuilder<List<Appointment>>(
      future: getMyAppointments(APIService.signedInUser?.userId ?? 0),
      builder:
          (BuildContext context, AsyncSnapshot<List<Appointment>> snapshot) {
            if (snapshot.connectionState==ConnectionState.waiting){
              return Center(child: Text("Loading...."),);
            }else if (snapshot.hasError){
              return Center(child: Text("Error...."),);

            }
            else{
              return ListView(
                  //children: snapshot.data.map((e) => AppointmentWidget(e)),
                children: snapshot.data!.map((e) => AppointmentWidget(e)).toList(),
              );
            }
          },
    );
  }

  Future<List<Appointment>> getMyAppointments(int userId) async{
    var appointments = await APIService.getmyappointments("Appointments", userId);
    return appointments;

  }

  Widget AppointmentWidget(appointment){

    // get doctor's ID (accBy) and write name and lastname
    return Padding(
      padding: EdgeInsets.fromLTRB(2, 2, 2, 2),
      child: Card(
        child: TextButton(
          onPressed: (){
            Navigator.push(context, MaterialPageRoute(builder: (context) => AppointmentDetails(appointment: appointment,)));

          },
          child: Padding(
              padding: EdgeInsets.all(20),
              child: Text("Date: " + appointment.date + " | " + appointment.appointmentStatus )),
        ),
      ),
    );
  }

}
