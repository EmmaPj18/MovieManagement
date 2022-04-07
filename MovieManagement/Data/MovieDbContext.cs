using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;

namespace MovieManagement.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().HasData(new Genero[]
            {
               new Genero { Id = 1, Descripcion = "Accion", Imagen = "https://i.insider.com/5b58c81ddce2e936008b4588?width=700" },
               new Genero { Id = 2, Descripcion = "Suspenso", Imagen = "https://userscontent2.emaze.com/images/4694d615-40ad-4c14-9e83-fb1a6ec3100e/1773d02a032d48cc6b858ff3d998e559.jpg"}
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
