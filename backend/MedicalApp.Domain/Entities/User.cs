using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MedicalApp.Domain.Entities
{
    public class User
    {
        public Guid id {  get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public string Role { get; set; } = "Patient";
        public DateTime CreatedAt { get; set; }
    }
}
