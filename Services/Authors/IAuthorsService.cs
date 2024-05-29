using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public interface IAuthorsService
    {
        IEnumerable<Author> GetAll();
        Author GetAuthor(int id);
        void CreateAuthor (Author author);
        void UpdateAuthor (Author author);
        void InactiveAuthor (int id);
        public void ActiveAuthor(int id);
    }
}