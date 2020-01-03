using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Occupation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Patient> Patients { get; set; }

        public ICollection<Patient> HusbandsPatients { get; set; }

    }
}
