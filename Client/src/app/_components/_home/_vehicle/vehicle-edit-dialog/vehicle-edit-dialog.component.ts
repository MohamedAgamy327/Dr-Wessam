import { Component, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MatSnackBar, MAT_DIALOG_DATA } from '@angular/material';
import { RepositoryService } from 'src/app/_services';

@Component({
  selector: 'app-vehicle-edit-dialog',
  templateUrl: './vehicle-edit-dialog.component.html',
  styleUrls: ['./vehicle-edit-dialog.component.css']
})

export class VehicleEditDialogComponent {

  editForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private dialogRef: MatDialogRef<VehicleEditDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any, private repository: RepositoryService, private snackBar: MatSnackBar) {
    this.createForm();
  }

  createForm() {
    this.editForm = this.formBuilder.group({
      id: [this.data.vehicle.id],
      vendorId: [this.data.vehicle.vendorId],
      subContractor: [this.data.vehicle.subContractor],
      type: [this.data.vehicle.type],
      brand: [this.data.vehicle.brand],
      model: [this.data.vehicle.model],
      year: [this.data.vehicle.year],
      characters: [this.data.vehicle.characters],
      numbers: [this.data.vehicle.numbers],
      plateNumber: [this.data.vehicle.plateNumber],
      expiryDate: [this.data.vehicle.expiryDate],
      latestMaintenanceDate: [this.data.vehicle.latestMaintenanceDate],
      maintenanceKM: [this.data.vehicle.maintenanceKM],
      tyreChangeDate: [this.data.vehicle.tyreChangeDate],
      tyreChangeKM: [this.data.vehicle.tyreChangeKM],
      nextTyreChangeKM: [this.data.vehicle.nextTyreChangeKM],
      gpsLink: [this.data.vehicle.gpsLink],
      username: [this.data.vehicle.username],
      password: [this.data.vehicle.password],
      lastSeenDate: [this.data.vehicle.lastSeenDate],
      comment: [this.data.vehicle.comment]
    });
  }

  public errorHandling = (control: string, error: string) => {
    return this.editForm.controls[control].hasError(error);
  }

  update() {
    this.repository.put('vehicles', this.editForm.value).subscribe(
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
