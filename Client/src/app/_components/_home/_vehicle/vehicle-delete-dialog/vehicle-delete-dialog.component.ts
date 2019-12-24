import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { RepositoryService } from 'src/app/_services';

@Component({
  selector: 'app-vehicle-delete-dialog',
  templateUrl: './vehicle-delete-dialog.component.html',
  styleUrls: ['./vehicle-delete-dialog.component.css']
})
export class VehicleDeleteDialogComponent {

  constructor(private dialogRef: MatDialogRef<VehicleDeleteDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any, private repository: RepositoryService, private snackBar: MatSnackBar) { }

  cancel(): void {
    this.dialogRef.close();
  }

  confirmDelete(): void {
    this.repository.delete(`vehicles/${this.data.id}`).subscribe(
      (res: any) => {
        this.snackBar.open('Deleted Successfully', '', {
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

}
