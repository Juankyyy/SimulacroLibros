using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsActiveController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsActiveController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPut("{id}")]
        public IActionResult AuthorsActive(int id)
        {
            try
            {   
                var author = _authorsService.GetAuthor(id);
                if (author.Status == "Activo")
                {
                    _authorsService.ActiveAuthor(id);
                    return Ok($"El author con id {id} ya está Activo");

                } else {
                    _authorsService.ActiveAuthor(id);
                    return Ok($"El author con id {id} pasó a estar Activo");
                }

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado al autor: {ex.Message}");
            }
        }
    }
}