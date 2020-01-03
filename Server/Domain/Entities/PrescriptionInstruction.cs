using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
 public	class PrescriptionInstruction
	{
		[Key]

		public int PrescriptionInstructionId { get; set; }
		[ForeignKey("Prescription")]

		public int	PrescriptionId { get; set; }
		public Prescription	Prescription { get; set; }
		[ForeignKey("Instruction")]

		public int InstructionId { get; set; }
		public Instruction Instruction { get; set; }
	}
}
