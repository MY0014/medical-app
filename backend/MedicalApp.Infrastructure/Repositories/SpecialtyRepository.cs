using MedicalApp.Application.Interfaces;
using MedicalApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalApp.Infrastructure.Repositories
{
    public class SpecialtyRepository: ISpecialityRepository
    {
        private readonly MedicalDbContext _context;

        public SpecialtyRepository(MedicalDbContext context)
        {
            _context = context;
        }


        public async Task<List<Specialty>> GetAllAsync()
        {
            return await _context.Specialties.ToListAsync();
        }

        public async Task<Specialty?> GetByIdAsync(Guid Id)
        {
            return await _context.Specialties.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
