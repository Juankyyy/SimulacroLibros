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
                var author = _authorsService.GetAuthor(id);
                if (author.Status == "Inactivo")
                {
                    _authorsService.InactiveAuthor(id);
                    return Ok($"El author con id {id} ya está inactivo");

                } else {
                    _authorsService.InactiveAuthor(id);
                    return Ok($"El author con id {id} pasó a estar inactivo");
                }

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado al autor: {ex.Message}");
            }
        }
    }
}