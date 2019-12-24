using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationContext context;
        public DriverRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<Driver> Add(Driver driver)
        {
            await context.Drivers.AddAsync(driver);
            return driver;
        }
        public Driver Edit(Driver driver)
        {
            context.Entry(driver).State = EntityState.Modified;
            return driver;
        }
        public async Task<Driver> Get(int id)
        {
            return await context.Drivers.Include(i => i.Vendor).AsNoTracking().SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task<IEnumerable<Driver>> Get()
        {
            return await context.Drivers.Include(i => i.Vendor).ToListAsync();
        }
        public void Remove(Driver driver)
        {
            context.Remove(driver);
        }
    }
}
