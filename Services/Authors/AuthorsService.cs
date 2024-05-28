using SimulacroLibros.Data;
using SimulacroLibros.Models;

namespace SimulacroLibros.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly SimulacroLibrosContext _context;

        public AuthorsService(SimulacroLibrosContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAll()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }

        public void CreateAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
}