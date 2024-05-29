using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class AuthorsCreateController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsCreateController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost]
        public IActionResult AuthorsCreate([FromBody] Author author)
        {
            try
            {
                if (author == null)
                {
                    return BadRequest($"Los datos del autor son nulos");
                }
                _authorsService.CreateAuthor(author);

                return Ok(author);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al crear autor: {ex.Message}");
            }
        }
    }
}