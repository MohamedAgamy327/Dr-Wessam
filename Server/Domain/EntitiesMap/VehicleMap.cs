using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.EntitiesMap
{
    public class VehicleMap
    {
        public VehicleMap(EntityTypeBuilder<Vehicle> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.ExpiryDate).HasColumnType("date");
            entityBuilder.Property(t => t.LastSeenDate).HasColumnType("date");
            entityBuilder.Property(t => t.LatestMaintenanceDate).HasColumnType("date");
            entityBuilder.Property(t => t.TyreChangeDate).HasColumnType("date");
            entityBuilder.HasOne(h => h.Vendor).WithMany(w => w.Vehicles).HasForeignKey(h => h.VendorId);
        }
    }
}
