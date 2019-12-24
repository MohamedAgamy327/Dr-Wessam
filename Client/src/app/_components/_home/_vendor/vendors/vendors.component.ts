import { RepositoryService } from 'src/app/_services';
import { Vendor } from 'src/app/_models';
import { VendorEditDialogComponent } from './../vendor-edit-dialog/vendor-edit-dialog.component';
import { VendorAddDialogComponent } from '../vendor-add-dialog/vendor-add-dialog.component';
import { VendorDeleteDialogComponent } from '../vendor-delete-dialog/vendor-delete-dialog.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource, MatPaginator, MatSort, MatSnackBar, MatDialog } from '@angular/material';

@Component({
  selector: 'app-vendors',
  templateUrl: './vendors.component.html',
  styleUrls: ['./vendors.component.css']
})

export class VendorsComponent implements OnInit {

  @ViewChild(MatSort, { static: true }) sort: MatSort;
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  displayedColumns: string[] = ['name', 'department', 'edit', 'delete'];
  vendors: Vendor[];
  dataSource = new MatTableDataSource<Vendor>();

  constructor(private repository: RepositoryService, private snackBar: MatSnackBar, private dialog: MatDialog) { }

  ngOnInit() {
    this.getVendors();
  }

  getVendors() {
    this.repository.get('vendors').subscribe(
      (res: any) => {
        this.vendors = res;
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
    const dialogRef = this.dialog.open(VendorAddDialogComponent, {
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.vendors.push(result);
        this.refeshData();
      }
    });
  }

  edit(vendor) {
    const dialogRef = this.dialog.open(VendorEditDialogComponent, {
      data: vendor
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const index = this.vendors.findIndex(f => f.id === result.id);
        this.vendors[index] = result;
        this.refeshData();
      }
    });
  }

  delete(vendor) {
    const dialogRef = this.dialog.open(VendorDeleteDialogComponent, {
      data: vendor
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        const index = this.vendors.findIndex(f => f.id === result.id);
        this.vendors.splice(index, 1);
        this.refeshData();
      }
    });
  }

  refeshData() {
    this.dataSource = new MatTableDataSource(this.vendors);
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

}
