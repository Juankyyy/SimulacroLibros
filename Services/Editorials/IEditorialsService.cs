using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public interface IEditorialsService
    {
        IEnumerable<Editorial> GetAll();
        Editorial GetOne(int id);
        void CreateEditorial(Editorial editorial);
        void UpdateEditorial(Editorial editorial);
        public void InactiveEditorial(int id);
        public void ActiveEditorial(int id);
    }
}