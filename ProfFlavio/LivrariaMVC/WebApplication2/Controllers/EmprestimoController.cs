using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmprestimoController : Controller
    {
        Data.ContextoDB contexto = new Data.ContextoDB();

        public IActionResult Index()
        {
            var emprestimosDB = contexto.Emprestimos.ToList();

            return View(emprestimosDB);

        }
        [HttpPost]
        public IActionResult Index(EmprestimoModel empretimo)
        {
            contexto.Emprestimos.Add(empretimo);
            contexto.SaveChanges();
            var emprestimosDB = contexto.Emprestimos.ToList();
            return View(emprestimosDB);
        }

        public IActionResult Cadastra()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastra(EmprestimoModel retirada) 
        {
            contexto.Add(retirada);
            return View(retirada);
        }

    }
}
