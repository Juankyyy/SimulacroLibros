using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsUpdateController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsUpdateController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPut("{id}")]
        public IActionResult AuthorsUpdate(Author author)
        {
            try
            {
                if (author == null)
                {
                    return BadRequest($"Los datos del Autor están nulos");
                }
                _authorsService.UpdateAuthor(author);

                return Ok(author);

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar autor: {ex.Message}");
            }
        }
    }
}