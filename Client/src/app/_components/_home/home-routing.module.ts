import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {
  HomeComponent, LandingComponent, KnowingsComponent,
  MedicineTypesComponent, OccupationsComponent, FrequencysComponent
} from '.';

const routes: Routes = [
  {
    path: '', component: HomeComponent, children: [
      {
        path: '', component: LandingComponent
      },
      {
        path: 'knowings', component: KnowingsComponent
      },
      {
        path: 'medicinetypes', component: MedicineTypesComponent
      },
      {
        path: 'occupations', component: OccupationsComponent
      },
      {
        path: 'frequencys', component: FrequencysComponent
      },
      {
        path: '', redirectTo: '', pathMatch: 'full'
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
