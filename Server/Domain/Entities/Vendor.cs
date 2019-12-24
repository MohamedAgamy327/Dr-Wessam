using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DepartmentEnum Department { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Driver> Drivers { get; set; }
    }
}
