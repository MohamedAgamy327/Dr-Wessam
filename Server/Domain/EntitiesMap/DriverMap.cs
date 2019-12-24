using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Domain.EntitiesMap
{
    public class DriverMap
    {
        public DriverMap(EntityTypeBuilder<Driver> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.DrugTestDate).HasColumnType("date");
            entityBuilder.Property(t => t.HiringDate).HasColumnType("date");
            entityBuilder.Property(t => t.LicenseExpiryDate).HasColumnType("date");
            entityBuilder.Property(t => t.MedicalExaminationDate).HasColumnType("date");
            entityBuilder.Property(t => t.TerminationDate).HasColumnType("date");
            entityBuilder.HasOne(h => h.Vendor).WithMany(w => w.Drivers).HasForeignKey(h => h.VendorId);
        }
    }
}
