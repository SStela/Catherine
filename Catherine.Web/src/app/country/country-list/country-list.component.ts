import { Component, OnInit } from '@angular/core';
import { CountryService } from '../country.service';
import { Country } from '../country';
import { Pagination } from 'src/app/shared/Response/Pagination';
import { CommonService } from 'src/app/shared/common.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-country-list',
  templateUrl: './country-list.component.html',
  styleUrls: ['./country-list.component.scss']
})
export class CountryListComponent implements OnInit {

  constructor(
    private common: CommonService,
    private countryService: CountryService,
    private router: Router
  ) { }

  public countries = Array<Country>();
  public pagination: Pagination;

  ngOnInit() {
    this.common.spinner.show();
    this.getCountries();
  }

  onEdit(id) {
    this.router.navigate(['countries', id]);
  }

  onDelete(id) {
    if(!confirm('Jeste li sigurni? Ova će akcija obrisati i pripadajuće gradove.')) return;
    this.countryService
      .deleteOne(id)
      .subscribe(_ => {
        this.getCountries();
        this.common.success('Akcija uspješno izvršena!');
      })
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
