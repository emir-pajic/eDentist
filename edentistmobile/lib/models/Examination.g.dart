// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Examination.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Examination _$ExaminationFromJson(Map<String, dynamic> json) => Examination(
      json['examinationId'] as int?,
      json['additionalInfo'] as String?,
      json['appointmentId'] as int?,
      json['userId'] as int?,
      json['treatmentId'] as int?,
      json['status'] as String?,
      json['treatmentsMaterialsId'] as int?,
      json['paymentTokenId'] as String?,
    );

Map<String, dynamic> _$ExaminationToJson(Examination instance) =>
    <String, dynamic>{
      'examinationId': instance.examinationId,
      'additionalInfo': instance.additionalInfo,
      'appointmentId': instance.appointmentId,
      'userId': instance.userId,
      'treatmentId': instance.treatmentId,
      'status': instance.status,
      'treatmentsMaterialsId': instance.treatmentsMaterialsId,
      'paymentTokenId': instance.paymentTokenId,
    };
