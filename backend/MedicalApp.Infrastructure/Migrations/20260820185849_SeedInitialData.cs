using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "Id", "ConsultationPrice", "CreatedAt", "Description", "FirstName", "IsActive", "LastName", "LicenseNumber" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 500.00m, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Médico especialista en medicina general.", "Carlos", true, "Ramírez", "MED-10001" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), 900.00m, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Especialista en cardiología.", "María", true, "González", "MED-10002" },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 750.00m, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Especialista en dermatología.", "Alejandro", true, "Torres", "MED-10003" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), 650.00m, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Especialista en pediatría y medicina general.", "Laura", true, "Martínez", "MED-10004" }
                });

            migrationBuilder.InsertData(
                table: "specialties",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Atención médica general.", "Medicina General" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Diagnóstico y tratamiento de enfermedades cardiovasculares.", "Cardiología" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Diagnóstico y tratamiento de enfermedades de la piel.", "Dermatología" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Atención médica para niños y adolescentes.", "Pediatría" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Diagnóstico y tratamiento de enfermedades neurológicas.", "Neurología" }
                });

            migrationBuilder.InsertData(
                table: "availabilities",
                columns: new[] { "Id", "DayOfWeek", "DoctorId", "EndTime", "IsActive", "StartTime" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-0001-0001-0001-000000000001"), 1, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new TimeSpan(0, 13, 0, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("aaaaaaaa-0001-0001-0001-000000000002"), 3, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new TimeSpan(0, 13, 0, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("bbbbbbbb-0002-0002-0002-000000000001"), 2, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new TimeSpan(0, 14, 0, 0, 0), true, new TimeSpan(0, 10, 0, 0, 0) },
                    { new Guid("bbbbbbbb-0002-0002-0002-000000000002"), 4, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new TimeSpan(0, 19, 0, 0, 0), true, new TimeSpan(0, 15, 0, 0, 0) },
                    { new Guid("cccccccc-0003-0003-0003-000000000001"), 1, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new TimeSpan(0, 19, 0, 0, 0), true, new TimeSpan(0, 15, 0, 0, 0) },
                    { new Guid("cccccccc-0003-0003-0003-000000000002"), 5, new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new TimeSpan(0, 13, 0, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("dddddddd-0004-0004-0004-000000000001"), 2, new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new TimeSpan(0, 13, 0, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0) },
                    { new Guid("dddddddd-0004-0004-0004-000000000002"), 4, new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new TimeSpan(0, 13, 0, 0, 0), true, new TimeSpan(0, 9, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "doctor_speciality",
                columns: new[] { "DoctorId", "SpecialityId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new Guid("44444444-4444-4444-4444-444444444444") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-0001-0001-0001-000000000001"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-0001-0001-0001-000000000002"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-0002-0002-0002-000000000001"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-0002-0002-0002-000000000002"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-0003-0003-0003-000000000001"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-0003-0003-0003-000000000002"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-0004-0004-0004-000000000001"));

            migrationBuilder.DeleteData(
                table: "availabilities",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-0004-0004-0004-000000000002"));

            migrationBuilder.DeleteData(
                table: "doctor_speciality",
                keyColumns: new[] { "DoctorId", "SpecialityId" },
                keyValues: new object[] { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.DeleteData(
                table: "doctor_speciality",
                keyColumns: new[] { "DoctorId", "SpecialityId" },
                keyValues: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.DeleteData(
                table: "doctor_speciality",
                keyColumns: new[] { "DoctorId", "SpecialityId" },
                keyValues: new object[] { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), new Guid("33333333-3333-3333-3333-333333333333") });

            migrationBuilder.DeleteData(
                table: "doctor_speciality",
                keyColumns: new[] { "DoctorId", "SpecialityId" },
                keyValues: new object[] { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.DeleteData(
                table: "doctor_speciality",
                keyColumns: new[] { "DoctorId", "SpecialityId" },
                keyValues: new object[] { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), new Guid("44444444-4444-4444-4444-444444444444") });

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));
        }
    }
}
