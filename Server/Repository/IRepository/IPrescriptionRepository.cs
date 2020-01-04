using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IPrescriptionRepository
    {
        Task<Prescription> Add(Prescription prescription);
        Prescription Edit(Prescription prescription);
        void Remove(Prescription prescription);
        Task<Prescription> GetById(int id);
        Task<IEnumerable<Prescription>> Get(int patientId);
    }
}
