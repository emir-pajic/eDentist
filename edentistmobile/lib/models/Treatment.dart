
import 'dart:ffi';

import 'package:json_annotation/json_annotation.dart';
part 'Treatment.g.dart';

@JsonSerializable()
class Treatment {

  int? treatmentId;
  String? description;
  double? price;

  Treatment(
      this.treatmentId,
        this.description,
        this.price);


  factory Treatment.fromJson(Map<String, dynamic> json) => _$TreatmentFromJson(json);

  Map<String, dynamic> toJson() => _$TreatmentToJson(this);

}