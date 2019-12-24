import { Component, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MatSnackBar, MAT_DIALOG_DATA } from '@angular/material';
import { RepositoryService } from 'src/app/_services';

@Component({
  selector: 'app-driver-edit-dialog',
  templateUrl: './driver-edit-dialog.component.html',
  styleUrls: ['./driver-edit-dialog.component.css']
})

export class DriverEditDialogComponent {

  editForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private dialogRef: MatDialogRef<DriverEditDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any, private repository: RepositoryService, private snackBar: MatSnackBar) {
    this.createForm();
  }

  createForm() {
    this.editForm = this.formBuilder.group({
      id: [this.data.driver.id],
      vendorId: [this.data.driver.vendorId],
      subContractor: [this.data.driver.subContractor],
      driverName: [this.data.driver.driverName],
      phoneNumber: [this.data.driver.phoneNumber],
      nationalId: [this.data.driver.nationalId],
      licenseType: [this.data.driver.licenseType],
      licenseExpiryDate: [this.data.driver.licenseExpiryDate],
      medicalExaminationDate: [this.data.driver.medicalExaminationDate],
      plateNumber: [this.data.driver.plateNumber],
      expiryDate: [this.data.driver.expiryDate],
      latestMaintenanceDate: [this.data.driver.latestMaintenanceDate],
      drugTestDate: [this.data.driver.drugTestDate],
      defensiveDriving: [this.data.driver.defensiveDriving],
      hiringDate: [this.data.driver.hiringDate],
      warningLetter1: [this.data.driver.warningLetter1],
      warningLetter2: [this.data.driver.warningLetter2],
      terminationDate: [this.data.driver.terminationDate],
      status: [this.data.driver.status],
      comment: [this.data.driver.comment]
    });
  }

  public errorHandling = (control: string, error: string) => {
    return this.editForm.controls[control].hasError(error);
  }

  update() {
    this.repository.put('drivers', this.editForm.value).subscribe(
      (res: any) => {
        this.snackBar.open('Edited Successfully', '', {
          duration: 1000,
          panelClass: ['green-snackbar']
        });
        this.dialogRef.close(res);
      },
      (err: any) => {
        this.snackBar.open(err.error.message, '', {
          duration: 1000,
          panelClass: ['red-snackbar']
        });
      });
  }

  cancel(): void {
    this.dialogRef.close();
  }

}
