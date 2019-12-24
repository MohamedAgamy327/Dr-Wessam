using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IVehicleRepository
    {
        Task<Vehicle> Add(Vehicle vehicle);
        Vehicle Edit(Vehicle vehicle);
        void Remove(Vehicle vehicle);
        Task<Vehicle> Get(int id);
        Task<IEnumerable<Vehicle>> Get();
    }
}
