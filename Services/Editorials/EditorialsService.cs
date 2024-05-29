using SimulacroLibros.Data;
using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public class EditorialsService : IEditorialsService
    {
        private readonly SimulacroLibrosContext _context;

        public EditorialsService(SimulacroLibrosContext context)
        {
            _context = context;
        }

        public IEnumerable<Editorial> GetAll()
        {
            return _context.Editorials.ToList();
        }
    }
}