import { Component, OnInit } from '@angular/core';
import { ActivatedRoute} from '@angular/router';
import { RepositoryService } from 'src/app/_services';
import { MatTableDataSource, MatPaginator, MatSort, MatSnackBar, MatDialog } from '@angular/material';
import { Patient, Occupation, Knowing } from 'src/app/_models';
@Component({
  selector: 'app-prescription',
  templateUrl: './prescription.component.html',
  styleUrls: ['./prescription.component.css']
})
export class PrescriptionComponent implements OnInit {
patientModel:any;
  constructor( private route:ActivatedRoute,private repository: RepositoryService,private snackBar: MatSnackBar,) { }

  ngOnInit() {
   let patientId= parseInt(this.route.snapshot.paramMap.get('id'));
   if (patientId!==undefined) {
     this.getPatientById(patientId); 
   }
      }

      
  getPatientById(Id:number) {
    this.repository.getById('patients',Id).subscribe(
      (res: any) => {
        console.log(res)
      this.patientModel=res;
      },
      (err: any) => {
        this.snackBar.open(err.error, '', {
          duration: 1000,
          panelClass: ['red-snackbar']
        });
      });
  }

}
