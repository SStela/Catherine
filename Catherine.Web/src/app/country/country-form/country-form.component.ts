import { Component, OnInit } from '@angular/core';
import { CountryService } from '../country.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Country } from '../country';

@Component({
  selector: 'app-country-form',
  templateUrl: './country-form.component.html',
  styleUrls: ['./country-form.component.scss']
})
export class CountryFormComponent implements OnInit {

  constructor(
    private countryService: CountryService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  public country: Country = new Country();

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      this.country.id = parseInt(params.get('id'))
    });

    this.getCountry();
  }

  getCountry() {
    this.countryService
      .getOne(this.country.id)
      .subscribe(response => { this.country = response; });
  }

}
