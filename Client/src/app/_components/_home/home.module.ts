import { AngularMaterialModule } from 'src/app/shared/material.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeRoutingModule } from './home-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { AddSpacePipe } from 'src/app/_custom-pipes/add-space.pipe';
import { CredentialService } from 'src/app/_services';
import {
  HomeComponent, LandingComponent,
  KnowingAddDialogComponent, KnowingDeleteDialogComponent, KnowingEditDialogComponent, KnowingsComponent,
  OccupationAddDialogComponent, OccupationDeleteDialogComponent, OccupationEditDialogComponent, OccupationsComponent,
  MedicineTypeAddDialogComponent, MedicineTypeDeleteDialogComponent,
  MedicineTypeEditDialogComponent, MedicineTypesComponent, FrequencysComponent,
  FrequencyAddDialogComponent, FrequencyEditDialogComponent,
  FrequencyDeleteDialogComponent, InstructionsComponent, InstructionAddDialogComponent,
  InstructionEditDialogComponent, InstructionDeleteDialogComponent
} from '.';
import { OnlyNumber } from 'src/app/_helpers';

@NgModule({
  declarations: [
    AddSpacePipe,
    OnlyNumber,
    HomeComponent,
    LandingComponent,
    KnowingAddDialogComponent, KnowingDeleteDialogComponent, KnowingEditDialogComponent, KnowingsComponent,
    OccupationAddDialogComponent, OccupationDeleteDialogComponent, OccupationEditDialogComponent, OccupationsComponent,
    MedicineTypeAddDialogComponent, MedicineTypeDeleteDialogComponent,
    MedicineTypeEditDialogComponent, MedicineTypesComponent, FrequencysComponent,
    FrequencyAddDialogComponent, FrequencyEditDialogComponent, FrequencyDeleteDialogComponent,
    InstructionsComponent, InstructionAddDialogComponent, InstructionEditDialogComponent, InstructionDeleteDialogComponent
  ],
  entryComponents: [
    KnowingAddDialogComponent, KnowingDeleteDialogComponent, KnowingEditDialogComponent,
    OccupationAddDialogComponent, OccupationDeleteDialogComponent, OccupationEditDialogComponent,
    MedicineTypeAddDialogComponent, MedicineTypeDeleteDialogComponent, MedicineTypeEditDialogComponent,
    FrequencyAddDialogComponent, FrequencyEditDialogComponent, FrequencyDeleteDialogComponent,
    InstructionAddDialogComponent, InstructionEditDialogComponent, InstructionDeleteDialogComponent
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
