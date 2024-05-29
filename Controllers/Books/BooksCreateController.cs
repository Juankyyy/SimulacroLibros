using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class BooksCreateController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksCreateController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPost]
        public IActionResult BooksCreate(Book book)
        {
            try
            {
                if (book == null)
                {
                    return BadRequest("Datos nulos");
                }
                _booksService.CreateBook(book);

                return Ok(book);
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al crear el libro: {ex.Message}");
            }
        }
    }
}