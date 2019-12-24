using Data.Context;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class VendorRepository : IVendorRepository
    {
        private readonly ApplicationContext context;
        public VendorRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<Vendor> Add(Vendor vendor)
        {
            await context.Vendors.AddAsync(vendor);
            return vendor;
        }
        public Vendor Edit(Vendor vendor)
        {
            context.Entry(vendor).State = EntityState.Modified;
            return vendor;
        }
        public async Task<Vendor> Get(int id)
        {
            return await context.Vendors.AsNoTracking().SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task<IEnumerable<Vendor>> Get()
        {
            return await context.Vendors.ToListAsync();
        }

        public async Task<bool> Get(string name, DepartmentEnum department)
        {
            return await context.Vendors.AsNoTracking().AnyAsync(s => s.Name == name && s.Department == department);
        }

        public async Task<bool> Get(int id, string name, DepartmentEnum department)
        {
            return await context.Vendors.AsNoTracking().AnyAsync(s => s.Id != id && s.Name == name && s.Department == department);
        }

        public void Remove(Vendor vendor)
        {
            context.Remove(vendor);
        }
    }
}
