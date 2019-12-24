import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent , LandingComponent, VehiclesComponent, DriversComponent, VendorsComponent } from '.';

const routes: Routes = [
  {
    path: '', component: HomeComponent, children: [
      {
        path: '', component: LandingComponent
      },
      {
        path: 'vehicles', component: VehiclesComponent
      },
      {
        path: 'drivers', component: DriversComponent
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
