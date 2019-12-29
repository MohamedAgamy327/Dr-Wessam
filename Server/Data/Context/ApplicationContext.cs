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
            new KnowingMap(modelBuilder.Entity<Knowing>());
            new FrequencyMap(modelBuilder.Entity<Frequency>());
            new OccupationMap(modelBuilder.Entity<Occupation>());          
            new MedicineTypeMap(modelBuilder.Entity<MedicineType>());
            modelBuilder.Seed();
        }

        public DbSet<Knowing> Knowings { get; set; }
        public DbSet<Frequency> Frequencys { get; set; }
        public DbSet<Occupation> Occupations { get; set; }      
        public DbSet<MedicineType> MedicineTypes { get; set; }
    }
}
