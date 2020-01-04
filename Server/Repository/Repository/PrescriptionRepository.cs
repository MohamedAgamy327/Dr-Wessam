using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly ApplicationContext context;
        public PrescriptionRepository(ApplicationContext context)
        {
            this.context = context;
        }
        public async Task<Prescription> Add(Prescription patient)
        {
            await context.Prescriptions.AddAsync(patient);
            return patient;
        }
        public Prescription Edit(Prescription prescription)
        {
            context.Entry(prescription).State = EntityState.Modified;
            return prescription;
        }
    
        public async Task<IEnumerable<Prescription>> Get( int PatientId)
        {
            return await context.Prescriptions.Where(p=>p.PatientId== PatientId).ToListAsync();
        }

        public void Remove(Prescription prescription)
        {
            context.Remove(prescription);
        }



        
    }
}
