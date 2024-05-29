using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class EditorialsCreateController : ControllerBase
    {
        private readonly IEditorialsService _editorialsService;

        public EditorialsCreateController(IEditorialsService editorialsService)
        {
            _editorialsService = editorialsService;
        }

        [HttpPost]
        public IActionResult EditorialsCreate(Editorial editorial)
        {
            try
            {
                if (editorial == null)
                {
                    return BadRequest($"Los datos de editorial están nulos");
                }
                _editorialsService.CreateEditorial(editorial);

                return Ok(editorial);
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al crear un editorial: {ex.Message}");
            }
        }
    }
}