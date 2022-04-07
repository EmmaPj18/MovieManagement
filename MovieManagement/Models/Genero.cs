namespace MovieManagement.Models;

public class Genero
{
    public Genero()
    {
        Peliculas = new HashSet<Pelicula>();
    }

    public int Id { get; set; }
    public string Descripcion { get; set; } = default!;
    public string? Imagen { get; set; } = default!;

    public ICollection<Pelicula> Peliculas { get; set; }
}

