using System;

namespace Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public string SubContractor { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Characters { get; set; }
        public string Numbers { get; set; }
        public string PlateNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? LatestMaintenanceDate { get; set; }
        public int? MaintenanceKM { get; set; }
        public DateTime? TyreChangeDate { get; set; }
        public int? TyreChangeKM { get; set; }
        public int? NextTyreChangeKM { get; set; }
        public string GPSLink { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastSeenDate { get; set; }
        public string Comment { get; set; }

    }
}
