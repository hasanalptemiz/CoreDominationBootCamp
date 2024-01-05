using Microsoft.EntityFrameworkCore ; 
using CoreDominationBootCamp.Models.ORM ;


namespace CoreDominationBootCamp.Context
{
    public class CoreDominationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer("Server=DESKTOP-9D3D7OQ\\SQLEXPRESS;Database=CoreDominationBootCamp;Trusted_Connection=True;");
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        
    }
}

