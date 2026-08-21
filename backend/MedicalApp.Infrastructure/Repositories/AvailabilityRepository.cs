using MedicalApp.Application.Interfaces;
using MedicalApp.Domain.Entities;
using MedicalApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Infrastructure.Repositories
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        private readonly MedicalDbContext _context;

        public AvailabilityRepository(MedicalDbContext context)
        {
            _context = context;
        }

        public async Task<List<Availability>> GetAllAsync()
        {
            return await _context.Availabilities
                .Where(x => x.IsActive)
                .ToListAsync();
        }

        public async Task<Availability?> GetByIdAsync(Guid id)
        {
            return await _context.Availabilities
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Availability>> GetByDoctorIdAsync(Guid DoctorId)
        {
            return await _context.Availabilities
                .Where(x => x.DoctorId == DoctorId && x.IsActive)
                .ToListAsync();
        }
    }
}
