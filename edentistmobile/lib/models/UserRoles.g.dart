// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'UserRoles.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

UserRoles _$UserRolesFromJson(Map<String, dynamic> json) => UserRoles(
      roleId: json['roleId'] as int?,
      userId: json['userId'] as int?,
      role: json['role'] == null
          ? null
          : Role.fromJson(json['role'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$UserRolesToJson(UserRoles instance) => <String, dynamic>{
      'roleId': instance.roleId,
      'userId': instance.userId,
      'role': instance.role,
    };
