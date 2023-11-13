using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExamen2.Models
{
    public class LibroAutor
    {
        public string tituloLibro { get; set; } = null;
        public string autorLibro { get; set; } = null;
        public int capitulosLibro { get; set; } 
        public int paginasLibro { get; set; }
        public double precioLibro { get; set; }
    }
}
