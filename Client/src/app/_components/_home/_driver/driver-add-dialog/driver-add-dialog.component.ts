import { Component, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { RepositoryService } from 'src/app/_services';

@Component({
  selector: 'app-driver-add-dialog',
  templateUrl: './driver-add-dialog.component.html',
  styleUrls: ['./driver-add-dialog.component.css']
})
export class DriverAddDialogComponent {

  addForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private dialogRef: MatDialogRef<DriverAddDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any, private repository: RepositoryService, private snackBar: MatSnackBar) {
    this.createForm();
  }

  createForm() {
    this.addForm = this.formBuilder.group({
      vendorId: ['', Validators.required],
      subContractor: [''],
      driverName: [''],
      phoneNumber: [''],
      nationalId: [''],
      licenseType: [''],
      licenseExpiryDate: [],
      medicalExaminationDate: [],
      drugTestDate: [],
      defensiveDriving: [''],
      hiringDate: [],
      warningLetter1: [''],
      warningLetter2: [''],
      terminationDate: [],
      status: [''],
      comment: ['']
    });
  }

  public errorHandling = (control: string, error: string) => {
    return this.addForm.controls[control].hasError(error);
  }

  save() {
    console.log(this.addForm.value);
    this.repository.post('drivers', this.addForm.value).subscribe(
      (res: any) => {

        this.snackBar.open('Added Successfully', '', {
          duration: 1000,
          panelClass: ['green-snackbar']
        });
        this.dialogRef.close(res);
      },
      (err: any) => {
        this.snackBar.open(err.error, '', {
          duration: 1000,
          panelClass: ['red-snackbar']
        });
      });
  }

  cancel(): void {
    this.dialogRef.close();
  }

}
