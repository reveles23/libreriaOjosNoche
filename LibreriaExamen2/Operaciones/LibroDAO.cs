using LibreriaExamen2.Context;
using LibreriaExamen2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExamen2.Operaciones
{
    public class LibroDAO
    {
        public LibreriaContext Context = new LibreriaContext();
        public bool agregarLibro (int IdAutor, string Titulo, int Capitulos, int Paginas, double Precio)
        {
            try
            {
                var autor = Context.Autors.Where(a => a.Id == IdAutor).FirstOrDefault();
                if (autor == null)
                {
                    return false;
                } else
                {
                    Libro libro = new Libro();
                    libro.IdAutor = IdAutor;
                    libro.Titulo = Titulo;
                    libro.Capitulos = Capitulos;
                    libro.Paginas = Paginas;
                    libro.Precio = Precio;
                    Context.Libros.Add(libro);
                    Context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Libro> obtenerLibros()
        {
            var listLibros = Context.Libros.ToList<Libro>();
            return listLibros;
        }

        public Libro obtenerLibroId (int id)
        {
            var libro = Context.Libros.Where(a => a.Id == id).FirstOrDefault();
            return libro;
        }

        public List<LibroAutor> obtenerAutorLibros()
        {
            var query = from a in Context.Libros
                        join m in Context.Autors on a.IdAutor
                        equals m.Id
                        select new LibroAutor
                        {
                            tituloLibro = a.Titulo,
                            autorLibro = m.NombreAutor,
                            capitulosLibro = a.Capitulos,
                            paginasLibro = a.Paginas,
                            precioLibro = a.Precio
                        };
            return query.ToList();
        }
    }
}
