using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastucture
{
    public class MovieDbContext :DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) :base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to many (member and rental)
            modelBuilder.Entity<Member>()
                .HasOne<Rental>(s => s.Rental)
                .WithMany(r => r.Members)
                .HasForeignKey(s => s.RentalId);
                

            //Many to Many (rental and movie)

            modelBuilder.Entity<MovieRental>()
                .HasKey(a=>new {a.RentalId, a.MovieId});

            //Handle Decimals to avoid Precision

            modelBuilder.Entity<Rental>()
                .Property(a => a.TotalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Movie>()
             .Property(a => a.RentalCost)
             .HasColumnType("decimal(18,2)");
        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }  
        public DbSet<MovieRental> MovieRentals { get; set; }

    }
}
