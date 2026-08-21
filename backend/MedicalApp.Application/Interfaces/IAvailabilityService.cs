using MedicalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Application.DTOs;

namespace MedicalApp.Application.Interfaces
{
    public interface IAvailabilityService
    {
        Task<List<AvailabilityDto>> GetAllAsync();
        Task<AvailabilityDto?> GetByIdAsync(Guid Id);
        Task<List<AvailabilityDto>> GetByDoctorIdAsync(Guid DoctorId);
    }
}
