using LibreriaExamen2.Context;
using LibreriaExamen2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExamen2.Operaciones
{
    public class AutorDAO
    {
        public LibreriaContext Context = new LibreriaContext();

        public bool agregarAutor (string nombre)
        {
            try
            {
                var autors = Context.Autors.Where(a => a.NombreAutor == nombre).FirstOrDefault();
                if (autors == null)
                {
                    Autor autor = new Autor();
                    autor.NombreAutor = nombre;
                    Context.Autors.Add(autor);
                    Context.SaveChanges();
                    return true;
                }else
                {
                    return false;
                }
            } 
            catch (Exception ex) 
            { 
                return false;
            }
        }

        public List<Autor> obtenerAutors()
        {
            var listAutors = Context.Autors.ToList<Autor>();
            return listAutors;
        }
    }
}
