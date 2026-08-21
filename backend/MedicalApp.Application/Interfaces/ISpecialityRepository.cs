using MedicalApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Application.Interfaces
{
    public interface ISpecialityRepository
    {
        Task<List<Specialty>> GetAllAsync();
        Task<Specialty?> GetByIdAsync(Guid Id);
    }
}
