import { Component, OnInit } from '@angular/core';
import { CountryService } from '../country.service';
import { Country } from '../country';
import { Pagination } from 'src/app/shared/Response/Pagination';
import { CommonService } from 'src/app/shared/common.service';

@Component({
  selector: 'app-country-list',
  templateUrl: './country-list.component.html',
  styleUrls: ['./country-list.component.scss']
})
export class CountryListComponent implements OnInit {

  constructor(
    private common: CommonService,
    private countryService: CountryService
  ) { }

  public countries = Array<Country>();
  public pagination: Pagination;

  ngOnInit() {
    this.common.spinner.show();
    this.getCountries();
  }

  onDelete(id) {
    if(!confirm('Jeste li sigurni?')) return;
    this.countryService
      .deleteOne(id)
      .subscribe(_ => this.getCountries())
  }

  getCountries() {
    this.countryService
      .getPage(1)
      .subscribe(({ data, pagination }) => {
        this.pagination = pagination;
        this.countries = data;
        this.common.spinner.hide();
      });
  }

}
