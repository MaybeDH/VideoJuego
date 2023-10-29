using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailController(
            ILogger<EmailController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
       
        [Route("")]
        [HttpPost]
        public IActionResult PostUsuario(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuario.Add(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        
        [Route("")]
        [HttpGet]
        public IEnumerable<Usuario> GetUsuario()
        {
            return _aplicacionContexto.Usuario.ToList();
        }
       
        [Route("id")]
        [HttpPut]
        public IActionResult PutUsuario([FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuario.Update(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
       
        [Route("id")]
        [HttpDelete]
        public IActionResult DeleteUsuario(int usuarioID)
        {
            _aplicacionContexto.Usuario.Remove(_aplicacionContexto.Usuario.ToList().Where(x => x.idUsuario == usuarioID).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(usuarioID);
        }
    }
}


