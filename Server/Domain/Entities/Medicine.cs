﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int MedicineTypeId { get; set; }
        public MedicineType MedicineType { get; set; }
        public int FrequencyId { get; set; }
        public Frequency Frequency { get; set; }
        public int Duration { get; set; }

    }
}
