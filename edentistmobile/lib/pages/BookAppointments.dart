import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:edentistmobile/services/APIService.dart';

class BookAppointment extends StatefulWidget {
  const BookAppointment({Key? key}) : super(key: key);

  @override
  State<BookAppointment> createState() => _BookAppointmentState();
}

class _BookAppointmentState extends State<BookAppointment> {
  DateTime dateTime =
      DateTime(DateTime.now().year, DateTime.now().month, DateTime.now().day, DateTime.now().hour, DateTime.now().minute);
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

                      final dnt = DateTime(
                          date.year,
                          date.month,
                          date.day,
                          dateTime.hour,
                          dateTime.minute);
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
                ))
              ]),
              ElevatedButton(
                child: Text('Book'),
                onPressed: () async {

                  Map data = {
                    'Date': '${dateTime}',
                    'UserId': '${APIService.signedInUser?.userId}',
                    'AppointmentStatus': 'Requested'
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
