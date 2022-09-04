import 'dart:convert';
import 'dart:typed_data';
import 'package:json_annotation/json_annotation.dart';

import 'Role.dart';

part 'UserRoles.g.dart';

@JsonSerializable()
class UserRoles {
  int? roleId;
  int? userId;
  Role? role;

  UserRoles({this.roleId, this.userId, this.role});

  factory UserRoles.fromJson(Map<String, dynamic> json) => _$UserRolesFromJson(json);

  Map<String, dynamic> toJson() => _$UserRolesToJson(this);
}