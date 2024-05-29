using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class BooksUpdateController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksUpdateController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPut("{id}")]
        public IActionResult BooksUpdate(Book book)
        {
            try
            {
                if(book == null)
                {
                    return BadRequest("Datos nulos");
                }
                _booksService.UpdateBook(book);

                return Ok(book);

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar el libro: {ex.Message}");
            }
        }
    }
}