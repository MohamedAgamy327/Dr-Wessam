import { Component, Inject } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA, MatSnackBar } from '@angular/material';
import { RepositoryService } from 'src/app/_services';

@Component({
  selector: 'app-knowing-edit-dialog',
  templateUrl: './knowing-edit-dialog.component.html',
  styleUrls: ['./knowing-edit-dialog.component.css']
})

export class KnowingEditDialogComponent {

  editForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private dialogRef: MatDialogRef<KnowingEditDialogComponent>,
              @Inject(MAT_DIALOG_DATA) private data: any, private repository: RepositoryService, private snackBar: MatSnackBar) {
    this.createForm();
  }

  createForm() {
    this.editForm = this.formBuilder.group({
      id: [this.data.id],
      name: [this.data.name, Validators.required]
    });
  }

  public errorHandling = (control: string, error: string) => {
    return this.editForm.controls[control].hasError(error);
  }

  update() {
    this.repository.put('knowings', this.editForm.value).subscribe(
      (res: any) => {
        this.snackBar.open('Edited Successfully', '', {
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
