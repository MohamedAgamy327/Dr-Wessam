using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IDriverRepository
    {
        Task<Driver> Add(Driver driver);
        Driver Edit(Driver driver);
        void Remove(Driver driver);
        Task<Driver> Get(int id);
        Task<IEnumerable<Driver>> Get();
    }
}
