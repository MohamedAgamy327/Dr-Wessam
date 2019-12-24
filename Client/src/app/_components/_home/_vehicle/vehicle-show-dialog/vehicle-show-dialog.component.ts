import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-vehicle-show-dialog',
  templateUrl: './vehicle-show-dialog.component.html',
  styleUrls: ['./vehicle-show-dialog.component.css']
})

export class VehicleShowDialogComponent {

  constructor(private dialogRef: MatDialogRef<VehicleShowDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any) { }

  cancel(): void {
    this.dialogRef.close();
  }


}
