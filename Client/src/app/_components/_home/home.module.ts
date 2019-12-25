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
  KnowingAddDialogComponent, KnowingDeleteDialogComponent, KnowingEditDialogComponent, KnowingsComponent,
  OccupationAddDialogComponent, OccupationDeleteDialogComponent, OccupationEditDialogComponent, OccupationsComponent,
  MedicineTypeAddDialogComponent, MedicineTypeDeleteDialogComponent, MedicineTypeEditDialogComponent, MedicineTypesComponent,

} from '.';
import { OnlyNumber } from 'src/app/_helpers';



@NgModule({
  declarations: [
    AddSpacePipe,
    OnlyNumber,
    HomeComponent,
    LandingComponent,

    VendorAddDialogComponent,
    VendorDeleteDialogComponent,
    VendorEditDialogComponent,
    VendorsComponent,
    KnowingAddDialogComponent, KnowingDeleteDialogComponent, KnowingEditDialogComponent, KnowingsComponent,
    OccupationAddDialogComponent, OccupationDeleteDialogComponent, OccupationEditDialogComponent, OccupationsComponent,
    MedicineTypeAddDialogComponent, MedicineTypeDeleteDialogComponent, MedicineTypeEditDialogComponent, MedicineTypesComponent,
  ],
  entryComponents: [

    VendorAddDialogComponent,
    VendorDeleteDialogComponent,
    VendorEditDialogComponent, KnowingAddDialogComponent, KnowingDeleteDialogComponent, KnowingEditDialogComponent,
    OccupationAddDialogComponent, OccupationDeleteDialogComponent, OccupationEditDialogComponent,
    MedicineTypeAddDialogComponent, MedicineTypeDeleteDialogComponent, MedicineTypeEditDialogComponent
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
