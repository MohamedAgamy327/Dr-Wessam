using Domain.Entities;
using Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IVendorRepository
    {
        Task<Vendor> Add(Vendor vendor);
        Vendor Edit(Vendor vendor);
        void Remove(Vendor vendor);
        Task<Vendor> Get(int id);

        Task<bool> Get(string name, DepartmentEnum department);

        Task<bool> Get(int id, string name, DepartmentEnum department);
        Task<IEnumerable<Vendor>> Get();
    }
}
