using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace eDentist.WebAPI.Database
{
    public partial class eDentistContext : DbContext
    {
        //public eDentistContext()
        //{
        //}

        public eDentistContext(DbContextOptions<eDentistContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<Examinations> Examinations { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Treatments> Treatments { get; set; }
        public virtual DbSet<TreatmentsMaterials> TreatmentsMaterials { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=.;Database=eDentist;Trusted_Connection=True;");
        //            }
        //        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Salt.Add(GenerateSalt());
            }



            modelBuilder.Entity<Countries>().HasData(

                new Countries
                {
                    CountryId = 1,
                    CountryName = "Bosnia and Herzegovina"
                });



            modelBuilder.Entity<Manufacturers>().HasData(
              new Manufacturers
              {
                  ManufacturerId = 1,
                  Name = "Bosnalijek",
                  FoundationYear = 1951,
                  CountryId = 1
              });


            modelBuilder.Entity<Materials>().HasData(
             new Materials
             {
                 MaterialId = 1,
                 Name = "Brufen 400mg",
                 ManufacturerId = 1
             });


            modelBuilder.Entity<Cities>().HasData(

                new Cities
                {
                    CityId = 1,
                    CityName = "Konjic",
                    CountryId = 1
                },
                new Cities
                {
                    CityId = 2,
                    CityName = "Sarajevo",
                    CountryId = 1
                }
                );

            modelBuilder.Entity<Users>().HasData
            (
                new Users
                {
                    UserId = 1,
                    FirstName = "Emir",
                    LastName = "Pajić",
                    Username = "Pajson",
                    CityId = 1,
                    Email = "emir.pajic@edu.fit.ba",
                    DateOfBirth = DateTime.Now,
                    Telephone = "061-918-661",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "pajson1"),
                    Image = File.ReadAllBytes("Files/admin.jpg")
                },
                new Users
                {
                    UserId = 2,
                    FirstName = "Emir",
                    LastName = "Pajić",
                    Username = "Pajson2",
                    CityId = 2,
                    Email = "emir.pajic2@edu.fit.ba",
                    DateOfBirth = DateTime.Now,
                    Telephone = "061-918-661",
                    PasswordSalt = Salt[1],
                    PasswordHash = GenerateHash(Salt[1], "pajson2"),
                    Image = File.ReadAllBytes("Files/user.jpg")
                }
            );
            modelBuilder.Entity<Roles>().HasData
            (
                new Roles { RoleId = 1, Name = "Admin" },
                new Roles { RoleId = 2, Name = "Patient" },
                new Roles { RoleId = 3, Name = "Staff" }
            );

            modelBuilder.Entity<UserRoles>().HasData(
                new UserRoles { UserRoleId = 1, UserId = 1, RoleId = 1 },
                new UserRoles { UserRoleId = 2, UserId = 2, RoleId = 2 }
                );

            modelBuilder.Entity<Days>().HasData(
                new Days
                {
                    DayId = 1,
                    Name = "Monday"
                },
                new Days
                {
                    DayId = 2,
                    Name = "Tuesday"
                },
                new Days
                {
                    DayId = 3,
                    Name = "Wednesday"
                },
                new Days
                {
                    DayId = 4,
                    Name = "Thursday"
                },
                new Days
                {
                    DayId = 5,
                    Name = "Friday"
                },
                new Days
                {
                    DayId = 6,
                    Name = "Saturday"
                },
                new Days
                {
                    DayId = 7,
                    Name = "Sunday"
                }
                );

            OnModelCreatingPartial(modelBuilder);
            //modelBuilder.Entity<Appointments>(entity =>
            //{
            //    entity.HasKey(e => e.AppointmentId)
            //        .HasName("PK__Appointm__8ECDFCA255656C67");

            //    entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

            //    entity.Property(e => e.Date).HasColumnType("datetime");

            //    entity.Property(e => e.DayId).HasColumnName("DayID");

            //    entity.Property(e => e.UserId).HasColumnName("UserID");

            //    entity.HasOne(d => d.Day)
            //        .WithMany(p => p.Appointments)
            //        .HasForeignKey(d => d.DayId)
            //        .HasConstraintName("FK__Appointme__DayID__34C8D9D1");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.Appointments)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK__Appointme__UserI__33D4B598");
            //});

            //modelBuilder.Entity<Cities>(entity =>
            //{
            //    entity.HasKey(e => e.CityId)
            //        .HasName("PK__Cities__F2D21A961E628E5B");

            //    entity.Property(e => e.CityId).HasColumnName("CityID");

            //    entity.Property(e => e.CityName)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.CountryId).HasColumnName("CountryID");

            //    entity.HasOne(d => d.Country)
            //        .WithMany(p => p.Cities)
            //        .HasForeignKey(d => d.CountryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__Cities__CountryI__267ABA7A");
            //});

            //modelBuilder.Entity<Countries>(entity =>
            //{
            //    entity.HasKey(e => e.CountryId)
            //        .HasName("PK__Countrie__10D160BF4CF373CB");

            //    entity.Property(e => e.CountryId).HasColumnName("CountryID");

            //    entity.Property(e => e.CountryName)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<Days>(entity =>
            //{
            //    entity.HasKey(e => e.DayId)
            //        .HasName("PK__Days__BF3DD8250E302424");

            //    entity.Property(e => e.DayId).HasColumnName("DayID");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<Examinations>(entity =>
            //{
            //    entity.HasKey(e => e.ExaminationId)
            //        .HasName("PK__Examinat__C4A924C0C6BA3F3C");

            //    entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");

            //    entity.Property(e => e.AdditionalInfo).HasMaxLength(500);

            //    entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

            //    entity.Property(e => e.PaymentTokenId)
            //        .IsRequired()
            //        .HasColumnName("PaymentTokenID")
            //        .HasMaxLength(100);

            //    entity.Property(e => e.Status)
            //        .IsRequired()
            //        .HasMaxLength(15);

            //    entity.Property(e => e.TreatmentsMaterialsId).HasColumnName("TreatmentsMaterialsID");

            //    entity.Property(e => e.UserId).HasColumnName("UserID");

            //    entity.HasOne(d => d.Appointment)
            //        .WithMany(p => p.Examinations)
            //        .HasForeignKey(d => d.AppointmentId)
            //        .HasConstraintName("FK__Examinati__Appoi__3F466844");

            //    entity.HasOne(d => d.TreatmentsMaterials)
            //        .WithMany(p => p.Examinations)
            //        .HasForeignKey(d => d.TreatmentsMaterialsId)
            //        .HasConstraintName("FK__Examinati__Treat__412EB0B6");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.Examinations)
            //        .HasForeignKey(d => d.UserId)
            //        .HasConstraintName("FK__Examinati__UserI__403A8C7D");
            //});

            //modelBuilder.Entity<Materials>(entity =>
            //{
            //    entity.HasKey(e => e.MaterialId)
            //        .HasName("PK__Material__C5061317DACACB70");

            //    entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<Roles>(entity =>
            //{
            //    entity.HasKey(e => e.RoleId)
            //        .HasName("PK__Roles__8AFACE3A86B8A7E3");

            //    entity.Property(e => e.RoleId).HasColumnName("RoleID");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(30);
            //});

            //modelBuilder.Entity<Treatments>(entity =>
            //{
            //    entity.HasKey(e => e.TreatmentId)
            //        .HasName("PK__Treatmen__1A57B7115EA7417A");

            //    entity.Property(e => e.TreatmentId).HasColumnName("TreatmentID");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(500);
            //});

            //modelBuilder.Entity<TreatmentsMaterials>(entity =>
            //{
            //    entity.HasKey(e => e.TreatmentMaterialId)
            //        .HasName("PK__Treatmen__C839E1E0A4240799");

            //    entity.Property(e => e.TreatmentMaterialId).HasColumnName("TreatmentMaterialID");

            //    entity.Property(e => e.MaterialId).HasColumnName("MaterialID");

            //    entity.Property(e => e.TreatmentId).HasColumnName("TreatmentID");

            //    entity.HasOne(d => d.Material)
            //        .WithMany(p => p.TreatmentsMaterials)
            //        .HasForeignKey(d => d.MaterialId)
            //        .HasConstraintName("FK__Treatment__Mater__3C69FB99");

            //    entity.HasOne(d => d.Treatment)
            //        .WithMany(p => p.TreatmentsMaterials)
            //        .HasForeignKey(d => d.TreatmentId)
            //        .HasConstraintName("FK__Treatment__Treat__3B75D760");
            //});

            //modelBuilder.Entity<UserRoles>(entity =>
            //{
            //    entity.HasKey(e => new { e.RoleId, e.UserId })
            //        .HasName("PK__UserRole__5B8242F0988ADC9A");

            //    entity.Property(e => e.RoleId).HasColumnName("RoleID");

            //    entity.Property(e => e.UserId).HasColumnName("UserID");

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.UserRoles)
            //        .HasForeignKey(d => d.RoleId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__UserRoles__RoleI__2E1BDC42");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.UserRoles)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__UserRoles__UserI__2F10007B");
            //});

            //modelBuilder.Entity<Users>(entity =>
            //{
            //    entity.HasKey(e => e.UserId)
            //        .HasName("PK__Users__1788CCACEBE642CF");

            //    entity.Property(e => e.UserId).HasColumnName("UserID");

            //    entity.Property(e => e.CityId).HasColumnName("CityID");

            //    entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

            //    entity.Property(e => e.Email)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.FirstName)
            //        .IsRequired()
            //        .HasMaxLength(30);

            //    entity.Property(e => e.LastName)
            //        .IsRequired()
            //        .HasMaxLength(30);

            //    entity.Property(e => e.Password)
            //        .IsRequired()
            //        .HasMaxLength(100);

            //    entity.Property(e => e.PasswordHash)
            //        .IsRequired()
            //        .HasMaxLength(200);

            //    entity.Property(e => e.PasswordSalt)
            //        .IsRequired()
            //        .HasMaxLength(200);

            //    entity.Property(e => e.Telephone)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.Username)
            //        .IsRequired()
            //        .HasMaxLength(30);

            //    entity.HasOne(d => d.City)
            //        .WithMany(p => p.Users)
            //        .HasForeignKey(d => d.CityId)
            //        .HasConstraintName("FK__Users__CityID__29572725");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
