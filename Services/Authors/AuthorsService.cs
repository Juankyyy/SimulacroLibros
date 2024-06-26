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

        public void UpdateAuthor(Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
        }

        public void InactiveAuthor(int id)
        {
            var author = _context.Authors.Find(id);

            author.Status = "Inactivo";
            _context.Authors.Update(author);
            _context.SaveChanges();
        }

        public void ActiveAuthor(int id)
        {
            var author = _context.Authors.Find(id);

            author.Status = "Activo";
            _context.Authors.Update(author);
            _context.SaveChanges();
        }
    }
}