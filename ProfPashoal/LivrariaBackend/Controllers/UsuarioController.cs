using LivrariaBackend.DAO;
using LivrariaBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaBackend.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController: ControllerBase
    {
        private LivrariaContext _context;
        public UsuarioController(LivrariaContext context)
        {
            _context = new LivrariaContext();
        }
        [HttpGet]
        public JsonResult GetUsuario() 
        {
            var usuarioDB = _context.Usuarios.ToList();
            return new JsonResult(usuarioDB);
        }

    }
}
