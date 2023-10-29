using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class VideoJuegoController : ControllerBase
    {
        private readonly ILogger<VideoJuegoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public VideoJuegoController(
            ILogger<VideoJuegoController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [Route("")]
        [HttpPost]
        public IActionResult PostVideoJuego(
            [FromBody] VideoJuego videoJuego)
        {
            _aplicacionContexto.VideoJuego.Add(videoJuego);
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuego);
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Email> GetVideoJuego()
        {
            return _aplicacionContexto.VideoJuego.ToList();
        }

        [Route("id")]
        [HttpPut]
        public IActionResult PutVideoJuego([FromBody] VideoJuego videoJuego)
        {
            _aplicacionContexto.VideoJuego.Update(videoJuego);
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuego);
        }

        [Route("id")]
        [HttpDelete]
        public IActionResult DeleteVideoJuego(int videoJuegoID)
        {
            _aplicacionContexto.Email.Remove(_aplicacionContexto.Email.ToList().Where(x => x.idEmail == videoJuegoID).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuegoID);
        }
    }
}



