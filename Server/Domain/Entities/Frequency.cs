using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Frequency
    {
        public int Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
    }
}
