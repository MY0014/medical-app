using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Domain.Entities
{
    public class DoctorSpecialty
    {
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid SpecialityId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
