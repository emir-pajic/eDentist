import 'dart:convert';
import 'dart:typed_data';
import 'package:json_annotation/json_annotation.dart';

import 'UserRoles.dart';


part 'User.g.dart';

@JsonSerializable()
class User{
int? userId;
String? firstName;
String? lastname;
String? username;
int? cityId;
String? email;
DateTime? dateOfBirth;
String? telephone;
String image;
String? role;
String? city;
List<UserRoles>? userRoles;

Uint8List get imageArray => base64Decode(image);


User({required this.userId, required this.firstName, required this.lastname, required this.username, required this.cityId, required this.email,
  required this.dateOfBirth, required this.telephone, required this.image, required this.role, required this.city, this.userRoles
});

factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

Map<String, dynamic> toJson() => _$UserToJson(this);

}