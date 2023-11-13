using LibreriaExamen2.Models;
using LibreriaExamen2.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILibreria.Controllers
{
    [Route("api")]
    [ApiController]
    public class AutorsController : ControllerBase
    {
        private AutorDAO autorDAO = new AutorDAO();

        [HttpPost("autor")]
        public bool agregarAutor([FromBody] Autor autor)
        {
            return autorDAO.agregarAutor(autor.NombreAutor);
        }

        [HttpGet("autor")]
        public List<Autor> obtenerAutors()
        {
            return autorDAO.obtenerAutors();
        }
    }
}
