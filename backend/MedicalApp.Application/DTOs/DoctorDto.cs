using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.DTOs
{
    public class DoctorDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName {  get; set; } = string.Empty;
        public string LicenseNumber {  get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public decimal ConsultationPrice {  get; set; }
        public bool IsActive { get; set; }
        public List<SpecialityDto> Specialities { get; set; } = new();
    }
}
