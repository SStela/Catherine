import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CitizenListComponent } from './citizen-list/citizen-list.component';


const routes: Routes = [
  { path: 'citizens', component: CitizenListComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CitizenRoutingModule { }
