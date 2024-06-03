using Microsoft.EntityFrameworkCore;
using LibreriaFinale.Model;

namespace LibreriaFinale.Database
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Libro> SetLibri { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var lines = System.IO.File.ReadAllLines("books.csv");
            var allBooks = lines.Skip(1)
                                .Select(line => line.Split(';'))
                                .Select(parts => new Libro
                                {
                                    Titolo = parts[0],
                                    Autore = parts[1],
                                    Genere = parts[2],
                                    ISBN = parts[3],
                                    Anno = parts[4]
                                })
                                .ToList();

            modelBuilder.Entity<Libro>().HasData(allBooks.ToArray());
        }
    }
}
