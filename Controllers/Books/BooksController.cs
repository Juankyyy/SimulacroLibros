using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            try
            {
                return Ok(_booksService.GetAll());
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al traer los libros: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            try
            {
                var book = _booksService.GetOne(id);

                if (book == null)
                {
                    return BadRequest($"Libro con id: {id} no encotrado");
                }
                return Ok(book);
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al traer el libro con id: {id}: {ex.Message}");
            }
        }
    }
}