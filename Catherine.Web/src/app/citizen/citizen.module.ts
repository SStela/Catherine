import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CitizenRoutingModule } from './citizen-routing.module';
import { CitizenListComponent } from './citizen-list/citizen-list.component';


@NgModule({
  declarations: [CitizenListComponent],
  imports: [
    CommonModule,
    CitizenRoutingModule
  ]
})
export class CitizenModule { }
