using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class EditorialsInactiveController : ControllerBase
    {
        private readonly IEditorialsService _editorialsService;

        public EditorialsInactiveController(IEditorialsService editorialsService)
        {
            _editorialsService = editorialsService;
        }

        [HttpPut("{id}")]
        public IActionResult EditorialsInactive(int id)
        {
            try
            {   
                var author = _editorialsService.GetOne(id);
                if (author.Status == "Inactivo")
                {
                    _editorialsService.InactiveEditorial(id);
                    return Ok($"La editorial con id {id} ya está inactivo");

                } else {
                    _editorialsService.InactiveEditorial(id);
                    return Ok($"La editorial con id {id} pasó a estar inactivo");
                }

            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al cambiar el estado a la editorial: {ex.Message}");
            }
        }
    }
}