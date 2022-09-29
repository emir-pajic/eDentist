import 'package:flutter/material.dart';
import 'package:edentistmobile/services/APIService.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();


}

class _HomeState extends State<Home> {
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
          title: Text('eDentist menu'),
          backgroundColor: Colors.blue[900],
        ),

        drawer: Drawer(
          backgroundColor: Colors.white,
          child: ListView(

            children: [
              DrawerHeader(child: Center(child: Text('', style: TextStyle(fontSize: 20, color: Colors.white),)),
                decoration: BoxDecoration(
                    color: Colors.blue[900],
                  image: new DecorationImage(fit: BoxFit.cover, image: MemoryImage(APIService.signedInUser!.imageArray))
                ),


              ),
              ListTile(
                title: Text('Book an Appointment'),
                onTap: () async {
                  //await APIService.getmyappointments("Appointments", APIService.signedInUser?.userId?? 0);
                  //Navigator.of(context).pushNamed('/appointmentsBook');
                  Navigator.of(context).pushNamed('/bookAppointment');

                },
              ),
              ListTile(
                title: Text('My Appointments'),
                onTap: () {
                  Navigator.of(context).pushNamed('/myAppointments');
                },
              ),
              ListTile(
                title: Text('My Examinations'),
                onTap: () {
                  Navigator.of(context).pushNamed('/myExaminations');
                },
              ),
              /*ListTile(
                title: Text('Payments'),
                onTap: () {
                  //Navigator.of(context).pushNamed('/payments');
                },
              ),*/
              ListTile(
                title: Text('Log out'),
                onTap: () {
                  APIService.username = null;
                  APIService.password = null;
                  APIService.signedInUser = null;
                  Navigator.of(context).pushNamed('/login');
                },
              )
            ],
          ),
        ),
        body:Stack(
          children: <Widget>[

            Align(

              alignment: Alignment.topCenter,

              child: Container(
                  padding: const EdgeInsets.all(15),
                  child: Image.asset('assets/logo.png', height: 250, width: 250,)),

            ),
            Align(
              alignment: Alignment.center,
              child: Text('\n \n \n \n \nWelcome to eDentist ${APIService.signedInUser?.firstName}  ${APIService.signedInUser?.lastname} \n \n \n Working hours: MON-SAT 08:00 - 19:00 \n \n ', style: TextStyle(fontSize: 20, color: Colors.white),),
            ),
          ],
        ),
      ),
    );
  }
}