// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'User.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User(
      userId: json['userId'] as int?,
      firstName: json['firstName'] as String?,
      lastname: json['lastname'] as String?,
      username: json['username'] as String?,
      cityId: json['cityId'] as int?,
      email: json['email'] as String?,
      dateOfBirth: json['dateOfBirth'] == null
          ? null
          : DateTime.parse(json['dateOfBirth'] as String),
      telephone: json['telephone'] as String?,
      image: json['image'] as String,
      role: json['role'] as String?,
      city: json['city'] as String?,
      userRoles: (json['userRoles'] as List<dynamic>?)
          ?.map((e) => UserRoles.fromJson(e as Map<String, dynamic>))
          .toList(),
    );

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'userId': instance.userId,
      'firstName': instance.firstName,
      'lastname': instance.lastname,
      'username': instance.username,
      'cityId': instance.cityId,
      'email': instance.email,
      'dateOfBirth': instance.dateOfBirth?.toIso8601String(),
      'telephone': instance.telephone,
      'image': instance.image,
      'role': instance.role,
      'city': instance.city,
      'userRoles': instance.userRoles,
    };
