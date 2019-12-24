export interface Driver {
  id: string;
  vendorId: string;
  vendorName: string;
  subContractor: string;
  driverName: string;
  nationalId: string;
  licenseType: string;
  licenseExpiryDate: Date;
  phoneNumber: string;
  medicalExaminationDate: Date;
  drugTestDate: Date;
  defensiveDriving: string;
  hiringDate: Date;
  warningLetter1: string;
  warningLetter2: string;
  terminationDate: Date;
  status: string;
  comment: string;
}
