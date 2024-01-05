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
}
}

