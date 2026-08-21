using MedicalApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicalApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvailabilityController : Controller
    {
        private readonly IAvailabilityService _service;

        public AvailabilityController(IAvailabilityService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var availablilities = await _service.GetAllAsync();
            return Ok(availablilities);
        }


        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var availability = await _service.GetByIdAsync(Id);
            if(availability == null)
            {
                return NotFound();
            }

            return Ok(availability);
        }

        [HttpGet("doctor/{DoctorId}")]
        public async Task<IActionResult> GetByDoctorId(Guid DoctorId)
        {
            var availabilities = await _service.GetByDoctorIdAsync(DoctorId);
            return Ok(availabilities);
        }

    }
}
