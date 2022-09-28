// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Treatment.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Treatment _$TreatmentFromJson(Map<String, dynamic> json) => Treatment(
      json['treatmentId'] as int?,
      json['description'] as String?,
      json['price'] as double?,
    );

Map<String, dynamic> _$TreatmentToJson(Treatment instance) => <String, dynamic>{
      'treatmentId': instance.treatmentId,
      'description': instance.description,
      'price': instance.price,
    };
