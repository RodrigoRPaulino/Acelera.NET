using LivrariaBackend.DAO;
using LivrariaBackend.Models;

namespace LivrariaBackend.Repository
{
    public class LivroRepository
    {
        private  LivrariaContext _context;
        public LivroRepository()
        {
            _context = new LivrariaContext();
        }
        public LivrosModel FindById(int cod) 
        {
            LivrosModel livroDB = _context.Livros.Find(cod);
            return livroDB;
        }
        public LivroRepository Save(LivrosModel livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return this;
        }
        
    }
}
