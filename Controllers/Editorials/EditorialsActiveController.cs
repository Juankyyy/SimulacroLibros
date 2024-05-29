using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class EditorialsActiveController : ControllerBase
    {
        private readonly IEditorialsService _editorialsService;

        public EditorialsActiveController(IEditorialsService editorialsService)
        {
            _editorialsService = editorialsService;
        }

        [HttpPut("{id}")]
        public IActionResult EditorialsActive(int id)
        {
            try
            {   
                var author = _editorialsService.GetOne(id);
                if (author.Status == "Activo")
                {
                    _editorialsService.ActiveEditorial(id);
                    return Ok($"La editorial con id {id} ya está Activo");

                } else {
                    _editorialsService.ActiveEditorial(id);
                    return Ok($"La editorial con id {id} pasó a estar Activo");
                }

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado a la editorial: {ex.Message}");
            }
        }
    }
}