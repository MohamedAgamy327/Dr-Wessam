using Data.Context;
using Domain.Entities;
using Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities.Password;

namespace Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext context;

        public UserRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task Add(User user)
        {
            await context.Users.AddAsync(user);
        }

        public Task<User> GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GetUser(string email)
        {
            return await context.Users.AnyAsync(s => s.Email == email);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> Login(string email, string password)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Email == email);

            if (user == null)
                return null;

            if (!SecurePassword.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return user;
        }

        public void Remove(User user)
        {
            throw new NotImplementedException();
        }
    }
}
