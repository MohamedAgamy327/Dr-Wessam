using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationContext context;
        public VehicleRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<Vehicle> Add(Vehicle vehicle)
        {
            await context.Vehicles.AddAsync(vehicle);
            return vehicle;
        }
        public Vehicle Edit(Vehicle vehicle)
        {
            context.Entry(vehicle).State = EntityState.Modified;
            return vehicle;
        }
        public async Task<Vehicle> Get(int id)
        {
            return await context.Vehicles.Include(i=>i.Vendor).AsNoTracking().SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task<IEnumerable<Vehicle>> Get()
        {
            return await context.Vehicles.Include(i => i.Vendor).ToListAsync();
        }
        public void Remove(Vehicle vehicle)
        {
            context.Remove(vehicle);
        }
    }
}
