import { RepositoryService } from 'src/app/_services';
import { Driver, Vendor } from 'src/app/_models';
import { DriverEditDialogComponent } from './../driver-edit-dialog/driver-edit-dialog.component';
import { DriverAddDialogComponent } from '../driver-add-dialog/driver-add-dialog.component';
import { DriverDeleteDialogComponent } from '../driver-delete-dialog/driver-delete-dialog.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator, MatSort, MatSnackBar, MatDialog } from '@angular/material';
import { DriverShowDialogComponent } from '../driver-show-dialog/driver-show-dialog.component';

@Component({
  selector: 'app-drivers',
  templateUrl: './drivers.component.html',
  styleUrls: ['./drivers.component.css']
})

export class DriversComponent implements OnInit {

  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['vendor', 'subContractor', 'driverName', 'nationalId', 'licenseType',
    'licenseExpiryDate', 'status', 'show', 'edit', 'delete'];
  drivers: Driver[];
  vendors: Vendor[];
  dataSource = new MatTableDataSource<any>();
  currentDate = new Date();

  constructor(private repository: RepositoryService, private snackBar: MatSnackBar, private dialog: MatDialog) { }

  ngOnInit() {
    this.getVendors();
    this.getDrivers();
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

  getDrivers() {
    this.repository.get('drivers').subscribe(
      (res: any) => {
        this.drivers = res;
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
    const dialogRef = this.dialog.open(DriverAddDialogComponent, {
      data: this.vendors
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.drivers.push(result);
        this.refeshData();
      }
    });
  }

  edit(driver) {

    const dialogRef = this.dialog.open(DriverEditDialogComponent, {
      data: { driver, vendors: this.vendors }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const index = this.drivers.findIndex(f => f.id === result.id);
        this.drivers[index] = result;
        this.refeshData();
      }
    });
  }

  delete(driver) {
    const dialogRef = this.dialog.open(DriverDeleteDialogComponent, {
      data: driver
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const index = this.drivers.findIndex(f => f.id === result.id);
        this.drivers.splice(index, 1);
        this.refeshData();
      }
    });
  }

  show(driver) {
    this.dialog.open(DriverShowDialogComponent, {
      data: driver
    });
  }

  refeshData() {
    this.dataSource = new MatTableDataSource(this.drivers);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  convert(date) {
    return new Date(date).getDate();
  }

}
