using Microsoft.EntityFrameworkCore;
using SP3Project.API.Models;

namespace SP3Project.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<OrderItem> OrderItems  { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryID = 1,
                    Name = "Cars",
                    Description = "Personal"
                },
                new Category()
                {
                    CategoryID = 2,
                    Name = "Trucks",
                    Description = "Business"
                }
            );
        }
    }
}
