namespace MovieManagement.Models;
public class PeliculasViewModel
{
    public IList<Pelicula> Peliculas { get; set; }
    public string? SearchBy { get; set; }
    public int? Genero { get; set; }
    public string? Prestadas { get; set; }
}
