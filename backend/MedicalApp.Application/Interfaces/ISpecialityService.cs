using MedicalApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.Interfaces
{
    public interface ISpecialityService
    {
        Task<List<SpecialityDto>> GetAllAsync();
        Task<SpecialityDto?> GetByIdAsync(Guid Id);
    }
}
