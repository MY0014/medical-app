using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.DTOs
{
    public class SpecialityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
