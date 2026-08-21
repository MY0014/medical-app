using MedicalApp.Application.DTOs;
using MedicalApp.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Application.Services
{
    public class SpecialityService: ISpecialityService
    {
        private readonly ISpecialityRepository _specialityRepository;
        public SpecialityService(ISpecialityRepository specialityRepository)
        {
            _specialityRepository = specialityRepository;
        }


        public async Task<List<SpecialityDto>> GetAllAsync()
        {
            var specialities = await _specialityRepository.GetAllAsync();
            var result = new List<SpecialityDto>();

            foreach(var speciality in specialities)
            {
                result.Add(new SpecialityDto
                {
                    Id= speciality.Id,
                    Name = speciality.Name,
                    Description = speciality.Description

                });
            }

            return result;
        }

        public async Task<SpecialityDto> GetByIdAsync(Guid Id)
        {
            var speciality = await _specialityRepository.GetByIdAsync(Id);
            if(speciality == null)
            {
                return null;
            }
            return new SpecialityDto
            {
                Id = speciality.Id,
                Name = speciality.Name,
                Description = speciality.Description
            };
        }

    }
}
