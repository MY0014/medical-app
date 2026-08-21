using MedicalApp.Application.DTOs;
using MedicalApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.Services
{
    public class AvailabilityService :IAvailabilityService
    {
        private readonly IAvailabilityRepository _repository;

        public AvailabilityService(IAvailabilityRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<AvailabilityDto>> GetAllAsync()
        {
            var available = await _repository.GetAllAsync();
            var result = new List<AvailabilityDto>();

            foreach(var ava in available)
            {
                result.Add(new AvailabilityDto
                {
                    Id = ava.Id,
                    DoctorId = ava.DoctorId,
                    DayOfWeek = ava.DayOfWeek,
                    StartTime = ava.StartTime,
                    EndTime = ava.EndTime,
                    IsActive = ava.IsActive
                });
            }
            return result;
        }

        public async Task<AvailabilityDto?> GetByIdAsync(Guid Id)
        {
            var availabilities = await _repository.GetByIdAsync(Id);
            if(availabilities == null)
            {
                return null;
            }

            return new AvailabilityDto
            {
                Id = availabilities.Id,
                DoctorId = availabilities.DoctorId,
                DayOfWeek = availabilities.DayOfWeek,
                StartTime = availabilities.StartTime,
                EndTime = availabilities.EndTime,
                IsActive = availabilities.IsActive
            };

        }

        public async Task<List<AvailabilityDto>> GetByDoctorIdAsync(Guid DoctorId)
        {
            var availabilities = await _repository.GetByDoctorIdAsync(DoctorId);
            var result = new List<AvailabilityDto>();

            foreach(var available in availabilities)
            {
                result.Add(new AvailabilityDto
                {
                    Id = available.Id,
                    DoctorId = available.DoctorId,
                    DayOfWeek= available.DayOfWeek,
                    StartTime = available.StartTime,
                    EndTime = available.EndTime,
                    IsActive = available.IsActive
                });
            }
            return result;
        }
    }
}
