import { Component, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { RepositoryService } from 'src/app/_services';

@Component({
  selector: 'app-vehicle-add-dialog',
  templateUrl: './vehicle-add-dialog.component.html',
  styleUrls: ['./vehicle-add-dialog.component.css']
})
export class VehicleAddDialogComponent {

  addForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private dialogRef: MatDialogRef<VehicleAddDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any, private repository: RepositoryService, private snackBar: MatSnackBar) {
    this.createForm();
  }

  createForm() {
    this.addForm = this.formBuilder.group({
      vendorId: ['', Validators.required],
      subContractor: [''],
      type: [''],
      brand: [''],
      model: [''],
      year: [''],
      characters: [''],
      numbers: [''],
      plateNumber: [''],
      expiryDate: [],
      latestMaintenanceDate: [],
      maintenanceKM: [],
      tyreChangeDate: [],
      tyreChangeKM: [],
      nextTyreChangeKM: [],
      gpsLink: [''],
      username: [''],
      password: [''],
      lastSeenDate: [],
      comment: ['']
    });
  }

  public errorHandling = (control: string, error: string) => {
    return this.addForm.controls[control].hasError(error);
  }

  save() {
    console.log(this.addForm.value);
    this.repository.post('vehicles', this.addForm.value).subscribe(
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
