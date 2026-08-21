using MedicalApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicalApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : Controller
    {
        private readonly IDoctorService _service;

        public DoctorController(IDoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await _service.GetAllAsync();
            return Ok(doctors);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var doctor = await _service.GetByIdAsync(Id);
            if(doctor == null)
            {
                return NotFound();
            }
            return Ok(doctor);
        }
    }
}
