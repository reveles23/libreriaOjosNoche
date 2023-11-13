using LibreriaExamen2.Models;
using LibreriaExamen2.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILibreria.Controllers
{
    [Route("api")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private LibroDAO libroDAO = new LibroDAO();

        [HttpPost("libro")]
        public bool agregarLibro ([FromBody]Libro libro)
        {
            return libroDAO.agregarLibro(libro.IdAutor, libro.Titulo, libro.Capitulos, libro.Paginas, libro.Precio);
        }

        [HttpGet("libro")]
        public List<Libro> obtenerLibro ()
        {
            return libroDAO.obtenerLibros();
        }

        [HttpGet("libroId")]
        public Libro obtenerLibroId (int id)
        {
            return libroDAO.obtenerLibroId(id);
        }

        [HttpGet("LibroAutor")]
        public List<LibroAutor> obtenerLibroAutor ()
        {
            return libroDAO.obtenerAutorLibros();
        }
    }
}
