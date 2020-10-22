using Microsoft.EntityFrameworkCore;
using CarRental.API.Domain.Models;

namespace CarRental.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Automobile> Automobile { get; set; }
        public DbSet<Order> Order {get;set;}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Category>().HasMany(p => p.Automobiles).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);


            builder.Entity<Automobile>().ToTable("Automobile");
            builder.Entity<Automobile>().HasKey(p => p.Id);
            builder.Entity<Automobile>().HasQueryFilter(p => !p.Rented);
            builder.Entity<Automobile>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Automobile>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Automobile>().Property(p => p.NumberOfOccupants).IsRequired();
            builder.Entity<Automobile>().Property(p => p.AutomaticTransmission).IsRequired();
            builder.Entity<Automobile>().Property(p => p.Rented).IsRequired();
            builder.Entity<Automobile>().Property(p => p.FuelType).IsRequired().HasConversion<string>();

            builder.Entity<Order>().ToTable("Order");
            builder.Entity<Order>().HasKey(p => p.Id);
            builder.Entity<Order>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Order>().Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Entity<Order>().Property(p => p.LastName).IsRequired();
            builder.Entity<Order>().Property(p => p.Phone).IsRequired();
            builder.Entity<Order>().Property(p => p.OrderDate).IsRequired();
            builder.Entity<Order>().Property(p => p.AutomobileId);

        }
    }
}