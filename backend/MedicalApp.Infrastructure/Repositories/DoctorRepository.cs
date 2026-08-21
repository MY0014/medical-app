using MedicalApp.Application.Interfaces;
using MedicalApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalApp.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly MedicalDbContext _context;

        public DoctorRepository(MedicalDbContext context)
        {
            _context = context;
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _context.Doctors
                .Include(x => x.DoctorSpecialties)
                .ThenInclude(x => x.Specialty)
                .ToListAsync();
        }

        public async Task<Doctor?> GetByIdAsync(Guid Id)
        {
            return await _context.Doctors
                .Include(X => X.DoctorSpecialties)
                .ThenInclude(x => x.Specialty)
                .FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
