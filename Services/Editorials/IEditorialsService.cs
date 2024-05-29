using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public interface IEditorialsService
    {
        IEnumerable<Editorial> GetAll();
    }
}