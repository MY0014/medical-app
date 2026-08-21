using MedicalApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.Interfaces
{
    public interface IDoctorService
    {
        Task<List<DoctorDto>> GetAllAsync();
        Task<DoctorDto?> GetByIdAsync(Guid Id);
    }
}
