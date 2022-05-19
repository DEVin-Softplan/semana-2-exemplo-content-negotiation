using content_negotiation.Models;
using content_negotiation.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace content_negotiation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            var lista = UsuarioRepository.Listar();
            return Ok(lista);
        }

        [HttpPost]
        [Route("criar")]
        public IActionResult Criar([FromBody] UsuarioModel model){

            UsuarioRepository.Adicionar(model);               
            return Created("link-usuario-criado", model);
        }     

    }
}