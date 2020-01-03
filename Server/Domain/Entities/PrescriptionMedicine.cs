using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
	 public class PrescriptionMedicine
	{
		[Key]
		public int PrescriptionMedicineId { get; set; }
		[ForeignKey("Medicine")]
		public int MedicineId { get; set; }
		public  Medicine Medicine { get; set; }
		[ForeignKey("Prescription")]
		public int PrescriptionId { get; set; }
		public virtual Prescription Prescription { get; set; }
		public string Notes_Eng { get; set; }
		public string Notes_AR { get; set; }
		public int Frequency { get; set; }
		public int Duration { get; set; }

	}
}
