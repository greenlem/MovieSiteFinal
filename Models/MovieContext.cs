using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSiteFinal.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet <Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "S", Name = "SciFi" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Jurassic Park",
                    Year = 1993,
                    Rating = 5,
                    GenreId = "S"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "The Lost World: Jurassic Park",
                    Year = 1997,
                    Rating = 4,
                    GenreId = "A"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Jurassic Park 3",
                    Year = 2001,
                    Rating = 4,
                    GenreId = "C"
                }
                );
        }
    }
}
