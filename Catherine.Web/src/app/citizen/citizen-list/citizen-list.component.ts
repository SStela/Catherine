import { Component, OnInit } from '@angular/core';
import { CitizenService } from '../citizen.service';

@Component({
  selector: 'app-citizen-list',
  templateUrl: './citizen-list.component.html',
  styleUrls: ['./citizen-list.component.scss']
})
export class CitizenListComponent implements OnInit {

  constructor(
    private citizenService: CitizenService
  ) { }

  public citizens = [];

  ngOnInit() {
    this.getCitizens();
  }

  getCitizens() {
    this.citizenService
      .getAll()
      .subscribe((response: any) => this.citizens = response);
  }

}
