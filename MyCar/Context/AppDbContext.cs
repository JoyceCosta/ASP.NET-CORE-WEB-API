using Microsoft.EntityFrameworkCore;
using MyCar.Models;

namespace MyCar.Context
{
    public class AppDbContext : DbContext
    { 
        public DbSet<Car> Cars { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\\mssqllocaldb;Database=Mycar;Trusted_Connection=True;MultipleaActiveResultSets=true");
        }
    }
}
