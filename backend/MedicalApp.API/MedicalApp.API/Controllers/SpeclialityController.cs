using MedicalApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MedicalApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SpeclialityController : Controller
    {
        private readonly ISpecialityService _service;
        
        public SpeclialityController(ISpecialityService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var specialities = await _service.GetAllAsync();
            return Ok(specialities);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var specialities = await _service.GetByIdAsync(Id);
            if(specialities == null)
            {
                return NotFound();
            }

            return Ok(specialities);

        }
    }
}
