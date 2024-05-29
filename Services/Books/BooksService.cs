using SimulacroLibros.Data;
using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public class BooksService : IBooksService
    {
        private readonly SimulacroLibrosContext _context;

        public BooksService(SimulacroLibrosContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetOne(int id)
        {
            return _context.Books.Find(id);
        }

        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}