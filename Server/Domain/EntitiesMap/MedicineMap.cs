using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.EntitiesMap
{
    public class MedicineMap
    {
        public MedicineMap(EntityTypeBuilder<Medicine> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.HasOne(h => h.MedicineType).WithMany(w => w.Medicines).HasForeignKey(h => h.MedicineTypeId);
            entityBuilder.HasOne(h => h.Frequency).WithMany(w => w.Medicines).HasForeignKey(h => h.FrequencyId);
        }
    }
}
