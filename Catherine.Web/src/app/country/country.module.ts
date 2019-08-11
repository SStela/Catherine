import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CountryRoutingModule } from './country-routing.module';
import { CountryListComponent } from './country-list/country-list.component';


@NgModule({
  declarations: [CountryListComponent],
  imports: [
    CommonModule,
    CountryRoutingModule
  ]
})
export class CountryModule { }
