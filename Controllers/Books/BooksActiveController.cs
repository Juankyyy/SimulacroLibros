using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class BooksActiveController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksActiveController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPut("{id}")]
        public IActionResult BooksActive(int id)
        {
            try
            {   
                var book = _booksService.GetOne(id);
                if (book.Status == "Activo")
                {
                    _booksService.ActiveBook(id);
                    return Ok($"El libro con id {id} ya está Activo");

                } else {
                    _booksService.ActiveBook(id);
                    return Ok($"El libro con id {id} pasó a estar Activo");
                }

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado del libro: {ex.Message}");
            }
        }
    }
}