using LivrariaBackend.DAO;
using LivrariaBackend.Models;
using LivrariaBackend.Repository;

namespace LivrariaBackend.Services
{
    
    public class LivroServices
    {
        LivroRepository _repository;
        public LivroServices(LivrariaContext context)
        {
            _repository = new LivroRepository();
        } 
        public LivrosModel Save(LivrosModel livro)
        {
            LivrosModel livroDB = _repository.FindById(livro.COD);
            if (livroDB != null)
            {
                _repository.Save(livroDB);
                return livroDB;
            }
            return livroDB;
        }

    }
    
}
