import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-driver-show-dialog',
  templateUrl: './driver-show-dialog.component.html',
  styleUrls: ['./driver-show-dialog.component.css']
})

export class DriverShowDialogComponent {

  constructor(private dialogRef: MatDialogRef<DriverShowDialogComponent>,
              @Inject(MAT_DIALOG_DATA) public data: any) { }

  cancel(): void {
    this.dialogRef.close();
  }


}
