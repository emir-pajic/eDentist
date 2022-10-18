import 'package:json_annotation/json_annotation.dart';
part 'Appointment.g.dart';

@JsonSerializable()
class Appointment {
  int? appointmentId;
  String? date;
  int? userId;
  int? dayId;
  bool? status;
  String? appointmentStatus;
  int? acceptedById;
  String? doctor;

  Appointment(
      {this.appointmentId,
        this.date,
        this.userId,
        this.dayId,
        this.status,
        this.appointmentStatus,
        this.acceptedById});

  factory Appointment.fromJson(Map<String, dynamic> json) => _$AppointmentFromJson(json);

  Map<String, dynamic> toJson() => _$AppointmentToJson(this);
}