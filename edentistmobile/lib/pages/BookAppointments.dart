import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:edentistmobile/services/APIService.dart';

import '../models/User.dart';

class BookAppointment extends StatefulWidget {
  const BookAppointment({Key? key}) : super(key: key);

  @override
  State<BookAppointment> createState() => _BookAppointmentState();
}

class _BookAppointmentState extends State<BookAppointment> {
  DateTime dateTime = DateTime(DateTime.now().year, DateTime.now().month,
      DateTime.now().day, DateTime.now().hour, DateTime.now().minute);
  List<User> doctors = [];
  List<DropdownMenuItem<String>> menuItems = [];
  String selectedValue = "test";

  void getDoctors() async {
    var gdocts = await APIService.getAllDoctors("User") as List;

    gdocts.forEach((element) {
      doctors.add(element);
    });

    doctors.forEach((element) {
      menuItems.add(DropdownMenuItem(
          child: Text(
              element.firstName.toString() + " " + element.lastname.toString()),
          value: element.userId.toString()));
    });

    setState(() {
      selectedValue = menuItems.first.value.toString();
    });
  }

  get dropdownItems => menuItems;

  @override
  void initState() {
    super.initState();
    WidgetsBinding.instance.addPostFrameCallback((_) {
      getDoctors();
    });
  }

  @override
  Widget build(BuildContext context) {
    final hours = dateTime.hour.toString().padLeft(2, '0');
    final minutes = dateTime.minute.toString().padLeft(2, '0');

    return Container(
      decoration: const BoxDecoration(
          image: DecorationImage(
              image: AssetImage('assets/bg.png'), fit: BoxFit.cover)),
      child: Scaffold(
        backgroundColor: Colors.transparent,
        appBar: AppBar(
          title: Text("Book an appointment"),
          backgroundColor: Colors.blue[900],
        ),
        body: Container(
          alignment: Alignment.center,
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              const Text(
                'Select Date and Time',
                style: TextStyle(fontSize: 36, color: Colors.white),
              ),
              const SizedBox(
                height: 16,
              ),
              Row(mainAxisAlignment: MainAxisAlignment.center, children: [
                Expanded(
                  child: ElevatedButton(
                    child: Text(
                        '${dateTime.day}/${dateTime.month}/${dateTime.year}'),
                    onPressed: () async {
                      final date = await pickDate();
                      if (date == null) return; // 'CANCEL'

                      final dnt = DateTime(date.year, date.month, date.day,
                          dateTime.hour, dateTime.minute);
                      setState(() {
                        dateTime = dnt;
                      });
                    },
                  ),
                ),
                const SizedBox(width: 12),
                Expanded(
                    child: ElevatedButton(
                  child: Text('$hours:$minutes'),
                  onPressed: () async {
                    final time = await pickTime();

                    if (time == null) return; //'CANCEL'

                    final newDateTime = DateTime(dateTime.year, dateTime.month,
                        dateTime.day, time.hour, time.minute);

                    setState(() {
                      dateTime = newDateTime;
                    });
                  },
                )),
              ]),
              const Text(
                "Select preferred doctor",
                style: TextStyle(color: Colors.white, fontSize: 18, height: 3),
              ),
              Container(
                child: DropdownButton<String>(
                  onTap: () async {
                    var response =
                        await APIService.getMostOftenDoctorOnMyAppointments(
                            "Appointments",
                            APIService.signedInUser?.userId ?? 0);
                    if (response != null) {
                      User? docUser = User.fromJson(response);

                      var message = 'Based on number of your visits, your most visited and recommended doctor is ${docUser.firstName} ${docUser.lastname}';
                      ScaffoldMessenger.of(context).showSnackBar(SnackBar(
                        content: SizedBox(
                            height: 60, child: Center(child: Text(message, style: const TextStyle(
                           fontSize: 18
                        ),))),
                        backgroundColor: Colors.blue,
                      ));
                    }
                  },
                  value: selectedValue,
                  hint: const Text(
                    "Select a Preferred doctor",
                    style: TextStyle(color: Colors.white),
                  ),
                  onChanged: (String? newValue) {

                    setState(() {
                      selectedValue = newValue!;
                    });
                  },
                  alignment: Alignment.center,
                  dropdownColor: Colors.white,
                  items: dropdownItems,
                  style: const TextStyle(
                      //te
                      color: Colors.blue, //Font color
                      fontSize: 20
                      //font size on dropdown button

                      ),
                ),
              ),
              ElevatedButton(
                child: const Text('Book'),
                onPressed: () async {
                  Map data = {
                    'Date': '${dateTime}',
                    'UserId': '${APIService.signedInUser?.userId}',
                    'AppointmentStatus': 'Requested',
                    'preferedDoctorId': int.parse(selectedValue)
                  };

                  var body = jsonEncode(data);

                  await APIService.bookAppointment("Appointments", body);

                  Navigator.of(context).pop();
                },
              )
            ],
          ),
        ),
      ),
    );
  }

  Future<DateTime?> pickDate() => showDatePicker(
      context: context,
      initialDate: dateTime,
      firstDate: DateTime(2022),
      lastDate: DateTime(2100));

  Future<TimeOfDay?> pickTime() => showTimePicker(
      context: context,
      initialTime: TimeOfDay(hour: dateTime.hour, minute: dateTime.minute));
}
