using LivrariaBackend.DAO;
using LivrariaBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {


        private LivrariaContext _context;
        public LivrosController(LivrariaContext context)
        {
            _context = new LivrariaContext();
        }
        [HttpGet]
        public JsonResult GetLivros()
        {
            var livrosDb = _context.Livros.ToList();
            return new JsonResult(livrosDb);
        }
        [HttpPost]
        public IActionResult AdicionarLivro([FromBody]LivrosModel livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
            return Ok();
        }
    }   
}
