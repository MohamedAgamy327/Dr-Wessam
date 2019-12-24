using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Utilities.Password;

namespace Data.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //SecurePassword.CreatePasswordHash("1234", out byte[] passwordHash, out byte[] passwordSalt);
            //modelBuilder.Entity<User>().HasData(
            //        new User
            //        {
            //            Id = 4,
            //            Name = "Agamy",
            //            Email = "agamy@pragimtech.com",
            //            PasswordHash = passwordHash,
            //            PasswordSalt = passwordSalt
            //        }
            //    );
        }
    }
}
