using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO.Medicine
{
    public class MedicineForAddDTO
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public int MedicineTypeId { get; set; }
        public int FrequencyId { get; set; }
        public int Duration { get; set; }
    }
}
