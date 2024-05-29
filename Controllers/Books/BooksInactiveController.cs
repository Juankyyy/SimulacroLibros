using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class BooksInactiveController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksInactiveController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpPut("{id}")]
        public IActionResult BooksInactive(int id)
        {
            try
            {   
                var book = _booksService.GetOne(id);
                if (book.Status == "Inactivo")
                {
                    _booksService.InactiveBook(id);
                    return Ok($"El libro con id {id} ya está inactivo");

                } else {
                    _booksService.InactiveBook(id);
                    return Ok($"El libro con id {id} pasó a estar inactivo");
                }

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado del libro: {ex.Message}");
            }
        }
    }
}