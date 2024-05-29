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

        public Editorial GetOne(int id)
        {
            return _context.Editorials.Find(id);
        }

        public void CreateEditorial(Editorial editorial)
        {
            _context.Editorials.Add(editorial);
            _context.SaveChanges();
        }

        public void UpdateEditorial(Editorial editorial)
        {
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
        }

        public void InactiveEditorial(int id)
        {
            var editorial = _context.Editorials.Find(id);

            editorial.Status = "Inactivo";
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
        }

        public void ActiveEditorial(int id)
        {
            var editorial = _context.Editorials.Find(id);

            editorial.Status = "Activo";
            _context.Editorials.Update(editorial);
            _context.SaveChanges();
        }
    }
}