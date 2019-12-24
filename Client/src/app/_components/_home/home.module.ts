import { AngularMaterialModule } from 'src/app/shared/material.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeRoutingModule } from './home-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { AddSpacePipe } from 'src/app/_custom-pipes/add-space.pipe';
import { CredentialService } from 'src/app/_services';
import {
  HomeComponent, LandingComponent,
  VendorAddDialogComponent, VendorDeleteDialogComponent, VendorEditDialogComponent, VendorsComponent,
  VehiclesComponent, VehicleDeleteDialogComponent, VehicleEditDialogComponent, VehicleShowDialogComponent, VehicleAddDialogComponent,
  DriverAddDialogComponent, DriverDeleteDialogComponent, DriverEditDialogComponent, DriverShowDialogComponent, DriversComponent
} from '.';
import { OnlyNumber } from 'src/app/_helpers';


@NgModule({
  declarations: [
    AddSpacePipe,
    OnlyNumber,
    HomeComponent,
    LandingComponent,
    VehiclesComponent,
    VehicleDeleteDialogComponent,
    VehicleEditDialogComponent,
    VehicleShowDialogComponent,
    VehicleAddDialogComponent,
    DriversComponent,
    DriverAddDialogComponent,
    DriverShowDialogComponent,
    DriverDeleteDialogComponent,
    DriverEditDialogComponent,
    VendorAddDialogComponent,
    VendorDeleteDialogComponent,
    VendorEditDialogComponent,
    VendorsComponent
  ],
  entryComponents: [
    VehicleDeleteDialogComponent,
    VehicleEditDialogComponent,
    VehicleShowDialogComponent,
    VehicleAddDialogComponent,
    DriverAddDialogComponent,
    DriverShowDialogComponent,
    DriverDeleteDialogComponent,
    DriverEditDialogComponent,
    VendorAddDialogComponent,
    VendorDeleteDialogComponent,
    VendorEditDialogComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    ReactiveFormsModule,
    AngularMaterialModule
  ],
  providers: [CredentialService]
})
export class HomeModule { }
