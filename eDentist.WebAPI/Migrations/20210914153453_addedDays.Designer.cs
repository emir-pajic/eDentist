﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDentist.WebAPI.Database;

namespace eDentist.WebAPI.Migrations
{
    [DbContext(typeof(eDentistContext))]
    [Migration("20210914153453_addedDays")]
    partial class addedDays
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eDentist.WebAPI.Database.Appointments", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DayId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DayId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Cities", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Konjic",
                            CountryId = 1
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Sarajevo",
                            CountryId = 1
                        });
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Countries", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Bosnia and Herzegovina"
                        });
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Days", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayId");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            DayId = 1,
                            Name = "Monday"
                        },
                        new
                        {
                            DayId = 2,
                            Name = "Tuesday"
                        },
                        new
                        {
                            DayId = 3,
                            Name = "Wednesday"
                        },
                        new
                        {
                            DayId = 4,
                            Name = "Thursday"
                        },
                        new
                        {
                            DayId = 5,
                            Name = "Friday"
                        },
                        new
                        {
                            DayId = 6,
                            Name = "Saturday"
                        },
                        new
                        {
                            DayId = 7,
                            Name = "Sunday"
                        });
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Examinations", b =>
                {
                    b.Property<int>("ExaminationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentTokenId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TreatmentsMaterialsId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ExaminationId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("TreatmentsMaterialsId");

                    b.HasIndex("UserId");

                    b.ToTable("Examinations");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Materials", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "Patient"
                        },
                        new
                        {
                            RoleId = 3,
                            Name = "Staff"
                        });
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Treatments", b =>
                {
                    b.Property<int>("TreatmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TreatmentId");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.TreatmentsMaterials", b =>
                {
                    b.Property<int>("TreatmentMaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<int?>("TreatmentId")
                        .HasColumnType("int");

                    b.HasKey("TreatmentMaterialId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("TreatmentsMaterials");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.UserRoles", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserRoleId = 1,
                            RoleId = 1,
                            UserId = 1
                        },
                        new
                        {
                            UserRoleId = 2,
                            RoleId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CityId = 1,
                            DateOfBirth = new DateTime(2021, 9, 14, 17, 34, 52, 526, DateTimeKind.Local).AddTicks(7501),
                            Email = "emir.pajic@edu.fit.ba",
                            FirstName = "Emir",
                            LastName = "Pajić",
                            PasswordHash = "tBhhEWPVEjfs2AW+27vJXukIxdY=",
                            PasswordSalt = "/mGY/nNKSS9TuY7pGJbjUA==",
                            Telephone = "061-918-661",
                            Username = "Pajson"
                        },
                        new
                        {
                            UserId = 2,
                            CityId = 2,
                            DateOfBirth = new DateTime(2021, 9, 14, 17, 34, 52, 540, DateTimeKind.Local).AddTicks(692),
                            Email = "emir.pajic2@edu.fit.ba",
                            FirstName = "Emir",
                            LastName = "Pajić",
                            PasswordHash = "HArO7THp6MX1GD6X20YPMC758YI=",
                            PasswordSalt = "KfbHDtE4Ph9q3K3woiIgbA==",
                            Telephone = "061-918-661",
                            Username = "Pajson2"
                        });
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Appointments", b =>
                {
                    b.HasOne("eDentist.WebAPI.Database.Days", "Day")
                        .WithMany("Appointments")
                        .HasForeignKey("DayId");

                    b.HasOne("eDentist.WebAPI.Database.Users", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Cities", b =>
                {
                    b.HasOne("eDentist.WebAPI.Database.Countries", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Examinations", b =>
                {
                    b.HasOne("eDentist.WebAPI.Database.Appointments", "Appointment")
                        .WithMany("Examinations")
                        .HasForeignKey("AppointmentId");

                    b.HasOne("eDentist.WebAPI.Database.TreatmentsMaterials", "TreatmentsMaterials")
                        .WithMany("Examinations")
                        .HasForeignKey("TreatmentsMaterialsId");

                    b.HasOne("eDentist.WebAPI.Database.Users", "User")
                        .WithMany("Examinations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.TreatmentsMaterials", b =>
                {
                    b.HasOne("eDentist.WebAPI.Database.Materials", "Material")
                        .WithMany("TreatmentsMaterials")
                        .HasForeignKey("MaterialId");

                    b.HasOne("eDentist.WebAPI.Database.Treatments", "Treatment")
                        .WithMany("TreatmentsMaterials")
                        .HasForeignKey("TreatmentId");
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.UserRoles", b =>
                {
                    b.HasOne("eDentist.WebAPI.Database.Roles", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDentist.WebAPI.Database.Users", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDentist.WebAPI.Database.Users", b =>
                {
                    b.HasOne("eDentist.WebAPI.Database.Cities", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");
                });
#pragma warning restore 612, 618
        }
    }
}
