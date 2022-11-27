using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "The Lord of the Rigns" },
                new Movie { Id = 2, Name = "The Hobiit" });
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "User 1", Movies = new List<Movie>() },
                new User { Id = 2, Name = "User 2", Movies = new List<Movie>() });
        }
    }
}
