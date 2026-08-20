using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Domain.Entities
{
    public class Specialty
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; } = new List<DoctorSpecialty>();

    }
}
