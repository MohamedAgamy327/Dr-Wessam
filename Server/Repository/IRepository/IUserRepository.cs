using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IUserRepository
    {
        Task Add(User user);
        void Remove(User user);
        Task<User> GetUser(int id);
        Task<bool> GetUser(string email);
        Task<User> Login(string email,string Password);
        Task<IEnumerable<User>> GetUsers();
    }
}
