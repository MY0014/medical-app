using MedicalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.Interfaces
{
    public interface IAvailabilityRepository
    {
        Task<List<Availability>> GetAllAsync();
        Task<Availability> GetByIdAsync(Guid Id);
        Task<List<Availability>> GetByDoctorIdAsync(Guid DoctorId);
    }
}
