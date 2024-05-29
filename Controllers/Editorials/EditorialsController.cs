using Microsoft.AspNetCore.Mvc;
using SimulacroLibros.Models;
using SimulacroLibros.Services;

namespace SimulacroLibros.AddControllers
{
    [ApiController]
    [Route("api/[Controller]")]
    
    public class EditorialsController : ControllerBase
    {
        private readonly IEditorialsService _editorialsService;

        public EditorialsController(IEditorialsService editorialsService)
        {
            _editorialsService = editorialsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetEditorials()
        {
            try
            {
                return Ok(_editorialsService.GetAll());
            } catch (Exception ex)
            {
                return StatusCode(500, $"Error al traer las editoriales: {ex.Message}");
            }
        }
    }
}