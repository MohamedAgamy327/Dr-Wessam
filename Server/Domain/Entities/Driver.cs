﻿using Domain.Enums;
using System;

namespace Domain.Entities
{
    public class Driver
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public string SubContractor { get; set; }
        public string DriverName { get; set; }
        public string NationalId { get; set; }     
        public LicenseTypeEnum LicenseType { get; set; }
        public DateTime? LicenseExpiryDate { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? MedicalExaminationDate { get; set; }
        public DateTime? DrugTestDate { get; set; }
        public string DefensiveDriving { get; set; }
        public DateTime? HiringDate{ get; set; }
        public string WarningLetter1 { get; set; }
        public string WarningLetter2 { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}