using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManagement.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = default!;
        public string? Sinopsis { get; set; }
        public DateTime FechaDeSalida { get; set; }
        public double Puntuacion { get; set; }
        public string? Imagen { get; set; }
        public bool EstaPrestada { get; set; } = false;
        public string? UsuarioPrestamo { get; set; }
        public DateTime? FechaPrestada { get; set; }

        [ForeignKey("Genero")]
        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }
    }
}
