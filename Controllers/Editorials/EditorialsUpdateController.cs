using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class EditorialsUpdateController : ControllerBase
    {
        private readonly IEditorialsService _editorialsService;

        public EditorialsUpdateController(IEditorialsService editorialsService)
        {
            _editorialsService = editorialsService;
        }

        [HttpPut("{id}")]
        public IActionResult EditorialsUpdate(Editorial editorial)
        {
            try
            {
                if (editorial == null)
                {
                    return BadRequest("Los datos están nulos");
                }
                _editorialsService.UpdateEditorial(editorial);

                return Ok(editorial);
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al actualizar la editorial: {ex.Message}");
            }
        }
    }
}