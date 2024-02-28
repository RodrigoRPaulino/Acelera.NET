using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetJsonResult()
        {
            List<string> usuarios = new List<string>();
            usuarios.Add("Popó");
            usuarios.Add("Bambam");

            return new JsonResult(usuarios);
        }
    }
}
