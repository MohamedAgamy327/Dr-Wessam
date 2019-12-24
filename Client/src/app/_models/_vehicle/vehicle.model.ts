export interface Vehicle {
  id: string;
  vendorId: string;
  vendorName: string;
  subContractor: string;
  type: string;
  brand: string;
  model: string;
  year: string;
  characters: string;
  numbers: string;
  plateNumber: string;
  expiryDate: Date;
  latestMaintenanceDate: Date;
  maintenanceKM: string;
  tyreChangeDate: Date;
  tyreChangeKM: string;
  nextTyreChangeKM: string;
  gpsLink: string;
  username: string;
  password: string;
  lastSeen: Date;
  comment: string;
}

