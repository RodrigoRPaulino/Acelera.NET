using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> logger;   
        public ClientesController(ILogger<ClientesController> logger)
        {
            this.logger = logger;
        }
        [HttpGet(Name = "MinhaAPI")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet(Name = "MinhaAPI/{nome}")]
        public IActionResult Post([FromRoute] string nome, [FromBody] string mae, [FromHeader] int key)
        {
            return Ok();
        }
       
        [HttpDelete(Name = "MinhaAPI")]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
