using Data.SeedData;
using Domain.Entities;
using Domain.EntitiesMap;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UserMap(modelBuilder.Entity<User>());
            new DriverMap(modelBuilder.Entity<Driver>());
            new VendorMap(modelBuilder.Entity<Vendor>());
            new VehicleMap(modelBuilder.Entity<Vehicle>());

            modelBuilder.Seed();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
