using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsInactiveController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsInactiveController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPut("{id}")]
        public IActionResult AuthorsInactive(int id)
        {
            try
            {   
                return Ok(_authorsService.InactiveAuthor(id));
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado al autor: {ex.Message}");
            }
        }
    }
}