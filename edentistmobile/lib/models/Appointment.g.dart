// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Appointment.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Appointment _$AppointmentFromJson(Map<String, dynamic> json) => Appointment(
      appointmentId: json['appointmentId'] as int?,
      date: json['date'] as String?,
      userId: json['userId'] as int?,
      dayId: json['dayId'] as int?,
      status: json['status'] as bool?,
      appointmentStatus: json['appointmentStatus'] as String?,
      acceptedById: json['acceptedById'] as int?,
    );

Map<String, dynamic> _$AppointmentToJson(Appointment instance) =>
    <String, dynamic>{
      'appointmentId': instance.appointmentId,
      'date': instance.date,
      'userId': instance.userId,
      'dayId': instance.dayId,
      'status': instance.status,
      'appointmentStatus': instance.appointmentStatus,
      'acceptedById': instance.acceptedById,
    };
