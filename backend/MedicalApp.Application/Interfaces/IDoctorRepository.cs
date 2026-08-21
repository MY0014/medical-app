using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Application.Interfaces
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetAllAsync();
        Task<Doctor?> GetByIdAsync(Guid Id);

    }
}
