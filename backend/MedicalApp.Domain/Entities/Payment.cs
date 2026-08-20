using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public Decimal Amount { get; set; }
        public string Status { get; set; }
        public string TransactionId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
