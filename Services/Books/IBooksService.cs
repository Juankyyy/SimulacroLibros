using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAll();
        Book GetOne(int id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
    }
}