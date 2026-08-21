using MedicalApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Application.DTOs;
using MedicalApp.Application.Interfaces;

namespace MedicalApp.Application.Services
{
    public class DoctorService : IDoctorService
    {
       private readonly IDoctorRepository _repository;
       
        public DoctorService(IDoctorRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<DoctorDto>> GetAllAsync()
        {
            var doctors = await _repository.GetAllAsync();
            var result = new List<DoctorDto>();

            foreach(var doctor in doctors)
            {
                var dto = new DoctorDto
                {
                    Id = doctor.Id,
                    FirstName = doctor.FirstName,
                    LastName = doctor.LastName,
                    LicenseNumber = doctor.LicenseNumber,
                    Description = doctor.Description,
                    ConsultationPrice = doctor.ConsultationPrice,
                    IsActive = doctor.IsActive
                };
                foreach(var doctorSpeciality in doctor.DoctorSpecialties)
                {
                    if(doctorSpeciality != null)
                    {
                        dto.Specialities.Add(new SpecialityDto
                        {
                            Id = doctorSpeciality.Specialty.Id,
                            Name = doctorSpeciality.Specialty.Name,
                            Description = doctorSpeciality.Specialty.Description
                        });
                    }
                }
                result.Add(dto);
            }
            return result;
        }

        public async Task<DoctorDto> GetByIdAsync(Guid Id)
        {
            var doctors = await _repository.GetByIdAsync(Id);
            if(doctors == null)
            {
                return null;
            }

            var dto = new DoctorDto
            {
                Id = doctors.Id,
                FirstName = doctors.FirstName,
                LastName = doctors.LastName,
                LicenseNumber = doctors.LicenseNumber,
                Description = doctors.Description,
                ConsultationPrice = doctors.ConsultationPrice,
                IsActive = doctors.IsActive
            };

            foreach(var doctorSpeciality in doctors.DoctorSpecialties)
            {
                if(doctorSpeciality.Specialty != null)
                {
                    dto.Specialities.Add(new SpecialityDto
                    {
                        Id = doctorSpeciality.Specialty.Id,
                        Name = doctorSpeciality.Specialty.Name,
                        Description = doctorSpeciality.Specialty.Description
                    });
                }
            }
            return dto;
        }
    }
}
