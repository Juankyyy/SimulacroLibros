using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            try
            {
                return Ok(_authorsService.GetAll());
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al traer los autores: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAutor(int id)
        {
            try
            {
                var author = _authorsService.GetAuthor(id);

                if (author == null)
                {
                    return NotFound($"No se encontró el autor con el id: {id}");
                }
                return Ok(author);
            } 
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al traer el autor con id: {id}: {ex.Message}");
            }
        }
    }
}