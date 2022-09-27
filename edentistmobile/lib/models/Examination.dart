import 'package:json_annotation/json_annotation.dart';
part 'Examination.g.dart';

@JsonSerializable()
class Examination{
int? examinationId;
String? additionalInfo;
int? appointmentId;
int? userId;
int? treatmentId;
String? status;
int? treatmentsMaterialsId;
String? paymentTokenId;

Examination(
    this.examinationId,
    this.additionalInfo,
    this.appointmentId,
    this.userId,
    this.treatmentId,
    this.status,
    this.treatmentsMaterialsId,
    this.paymentTokenId
    );

factory Examination.fromJson(Map<String, dynamic> json) => _$ExaminationFromJson(json);

Map<String, dynamic> toJson() => _$ExaminationToJson(this);

}