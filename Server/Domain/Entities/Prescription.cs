using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	public class Prescription
	{
		[Key]
		public int PrescriptionId { get; set; }
		public string Diagonsis { get; set; }

		public virtual ICollection<PrescriptionMedicine> Medicines { get; set; }
		public virtual ICollection<PrescriptionInstruction> Instructions { get; set; }

		[ForeignKey("Patient")]
		public  int PatientId { get; set; }
		public  Patient Patient { get; set; }



	}
}
