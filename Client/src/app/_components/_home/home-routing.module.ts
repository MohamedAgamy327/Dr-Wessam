import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent, LandingComponent, VendorsComponent, KnowingsComponent, MedicineTypesComponent, OccupationsComponent } from '.';

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
        path: 'Medicinetypes', component: MedicineTypesComponent
      },
      {
        path: 'occupations', component: OccupationsComponent
      },
      {
        path: 'vendors', component: VendorsComponent
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
