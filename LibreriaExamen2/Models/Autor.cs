using System;
using System.Collections.Generic;

namespace LibreriaExamen2.Models;

public partial class Autor
{
    public int Id { get; set; }

    public string NombreAutor { get; set; } = null!;

    public virtual ICollection<Libro>? Libros { get; set; } = new List<Libro>();
}
