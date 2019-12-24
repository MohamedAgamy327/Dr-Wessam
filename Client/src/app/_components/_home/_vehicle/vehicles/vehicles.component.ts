import { RepositoryService } from 'src/app/_services';
import { Vehicle, Vendor } from 'src/app/_models';
import { VehicleEditDialogComponent } from './../vehicle-edit-dialog/vehicle-edit-dialog.component';
import { VehicleAddDialogComponent } from '../vehicle-add-dialog/vehicle-add-dialog.component';
import { VehicleDeleteDialogComponent } from '../vehicle-delete-dialog/vehicle-delete-dialog.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator, MatSort, MatSnackBar, MatDialog } from '@angular/material';
import { VehicleShowDialogComponent } from '../vehicle-show-dialog/vehicle-show-dialog.component';

@Component({
  selector: 'app-vehicles',
  templateUrl: './vehicles.component.html',
  styleUrls: ['./vehicles.component.css']
})

export class VehiclesComponent implements OnInit {

  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['vendor', 'subContractor', 'type', 'characters', 'numbers', 'expiryDate', 'show', 'edit', 'delete'];
  vehicles: Vehicle[];
  vendors: Vendor[];
  dataSource = new MatTableDataSource<any>();
  currentDate = new Date();

  constructor(private repository: RepositoryService, private snackBar: MatSnackBar, private dialog: MatDialog) { }

  ngOnInit() {
    this.getVendors();
    this.getVehicles();
  }

  getVendors() {
    this.repository.get('vendors').subscribe(
      (res: any) => {
        this.vendors = res;
      },
      (err: any) => {
        this.snackBar.open(err.error, '', {
          duration: 1000,
          panelClass: ['red-snackbar']
        });
      });
  }

  getVehicles() {
    this.repository.get('vehicles').subscribe(
      (res: any) => {
        this.vehicles = res;
        this.refeshData();
      },
      (err: any) => {
        this.snackBar.open(err.error, '', {
          duration: 1000,
          panelClass: ['red-snackbar']
        });
      });
  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  add() {
    const dialogRef = this.dialog.open(VehicleAddDialogComponent, {
      data: this.vendors
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.vehicles.push(result);
        this.refeshData();
      }
    });
  }

  edit(vehicle) {

    const dialogRef = this.dialog.open(VehicleEditDialogComponent, {
      data: { vehicle, vendors: this.vendors }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const index = this.vehicles.findIndex(f => f.id === result.id);
        this.vehicles[index] = result;
        this.refeshData();
      }
    });
  }

  delete(vehicle) {
    const dialogRef = this.dialog.open(VehicleDeleteDialogComponent, {
      data: vehicle
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const index = this.vehicles.findIndex(f => f.id === result.id);
        this.vehicles.splice(index, 1);
        this.refeshData();
      }
    });
  }

  show(vehicle) {
    this.dialog.open(VehicleShowDialogComponent, {
      data: vehicle
    });
  }

  refeshData() {
    this.dataSource = new MatTableDataSource(this.vehicles);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  convert(date) {
    return new Date(date).getDate();
  }

}
