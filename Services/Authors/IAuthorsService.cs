using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public interface IAuthorsService
    {
        IEnumerable<Author> GetAll();
        Author GetAuthor(int id);

        void CreateAuthor (Author author);
    }
}