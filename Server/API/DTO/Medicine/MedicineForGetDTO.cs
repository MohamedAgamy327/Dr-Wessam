using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO.Medicine
{
    public class MedicineForGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int MedicineTypeId { get; set; }
        public string MedicineType { get; set; }
        public int FrequencyId { get; set; }
        public string Frequency { get; set; }
        public int Duration { get; set; }
    }
}
