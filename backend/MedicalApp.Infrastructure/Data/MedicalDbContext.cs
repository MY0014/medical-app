
using Microsoft.EntityFrameworkCore;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infrastructure.Data
{
    public class MedicalDbContext : DbContext
    {
        public MedicalDbContext(DbContextOptions<MedicalDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }



        //INYECCION DE INFORMACION
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(MedicalDbContext).Assembly);

            modelBuilder.Entity<Specialty>().HasData(
                new Specialty
                {
                    Id = SeedData.GeneralMedicineId,
                    Name = "Medicina General",
                    Description = "Atención médica general."
                },
                new Specialty
                {
                    Id = SeedData.CardiologyId,
                    Name = "Cardiología",
                    Description = "Diagnóstico y tratamiento de enfermedades cardiovasculares."
                },
                new Specialty
                {
                    Id = SeedData.DermatologyId,
                    Name = "Dermatología",
                    Description = "Diagnóstico y tratamiento de enfermedades de la piel."
                },
                new Specialty
                {
                    Id = SeedData.PediatricsId,
                    Name = "Pediatría",
                    Description = "Atención médica para niños y adolescentes."
                },
                new Specialty
                {
                    Id = SeedData.NeurologyId,
                    Name = "Neurología",
                    Description = "Diagnóstico y tratamiento de enfermedades neurológicas."
                }
            );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = SeedData.CarlosId,
                    FirstName = "Carlos",
                    LastName = "Ramírez",
                    LicenseNumber = "MED-10001",
                    Description = "Médico especialista en medicina general.",
                    ConsultationPrice = 500.00m,
                    IsActive = true,
                    CreatedAt = SeedData.CreatedAt
                },
                new Doctor
                {
                    Id = SeedData.MariaId,
                    FirstName = "María",
                    LastName = "González",
                    LicenseNumber = "MED-10002",
                    Description = "Especialista en cardiología.",
                    ConsultationPrice = 900.00m,
                    IsActive = true,
                    CreatedAt = SeedData.CreatedAt
                },
                new Doctor
                {
                    Id = SeedData.AlejandroId,
                    FirstName = "Alejandro",
                    LastName = "Torres",
                    LicenseNumber = "MED-10003",
                    Description = "Especialista en dermatología.",
                    ConsultationPrice = 750.00m,
                    IsActive = true,
                    CreatedAt = SeedData.CreatedAt
                },
                new Doctor
                {
                    Id = SeedData.LauraId,
                    FirstName = "Laura",
                    LastName = "Martínez",
                    LicenseNumber = "MED-10004",
                    Description = "Especialista en pediatría y medicina general.",
                    ConsultationPrice = 650.00m,
                    IsActive = true,
                    CreatedAt = SeedData.CreatedAt
                }
            );

            modelBuilder.Entity<DoctorSpecialty>().HasData(
                new
                {
                    DoctorId = SeedData.CarlosId,
                    SpecialityId = SeedData.GeneralMedicineId
                },
                new
                {
                    DoctorId = SeedData.MariaId,
                    SpecialityId = SeedData.CardiologyId
                },
                new
                {
                    DoctorId = SeedData.AlejandroId,
                    SpecialityId = SeedData.DermatologyId
                },
                new
                {
                    DoctorId = SeedData.LauraId,
                    SpecialityId = SeedData.PediatricsId
                },
                new
                {
                    DoctorId = SeedData.LauraId,
                    SpecialityId = SeedData.GeneralMedicineId
                }
            );

            modelBuilder.Entity<Availability>().HasData(
                new Availability
                {
                    Id = Guid.Parse("aaaaaaaa-0001-0001-0001-000000000001"),
                    DoctorId = SeedData.CarlosId,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(13, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("aaaaaaaa-0001-0001-0001-000000000002"),
                    DoctorId = SeedData.CarlosId,
                    DayOfWeek = DayOfWeek.Wednesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(13, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("bbbbbbbb-0002-0002-0002-000000000001"),
                    DoctorId = SeedData.MariaId,
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(14, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("bbbbbbbb-0002-0002-0002-000000000002"),
                    DoctorId = SeedData.MariaId,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(15, 0, 0),
                    EndTime = new TimeSpan(19, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("cccccccc-0003-0003-0003-000000000001"),
                    DoctorId = SeedData.AlejandroId,
                    DayOfWeek = DayOfWeek.Monday,
                    StartTime = new TimeSpan(15, 0, 0),
                    EndTime = new TimeSpan(19, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("cccccccc-0003-0003-0003-000000000002"),
                    DoctorId = SeedData.AlejandroId,
                    DayOfWeek = DayOfWeek.Friday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(13, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("dddddddd-0004-0004-0004-000000000001"),
                    DoctorId = SeedData.LauraId,
                    DayOfWeek = DayOfWeek.Tuesday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(13, 0, 0),
                    IsActive = true
                },
                new Availability
                {
                    Id = Guid.Parse("dddddddd-0004-0004-0004-000000000002"),
                    DoctorId = SeedData.LauraId,
                    DayOfWeek = DayOfWeek.Thursday,
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(13, 0, 0),
                    IsActive = true
                }
            );
        }


    }
}
