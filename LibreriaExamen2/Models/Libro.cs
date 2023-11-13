using System;
using System.Collections.Generic;

namespace LibreriaExamen2.Models;

public partial class Libro
{
    public int Id { get; set; }

    public int IdAutor { get; set; }

    public string Titulo { get; set; } = null!;

    public int Capitulos { get; set; }

    public int Paginas { get; set; }

    public double Precio { get; set; }

    public virtual Autor? IdAutorNavigation { get; set; } = null!;
}
