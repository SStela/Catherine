import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Country } from './country';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';
import { DetailResponse } from '../shared/Response/DetailResponse';

@Injectable({
  providedIn: 'root'
})
export class CountryService {

  constructor(
    private http: HttpClient
  ) { }

  public getPage(page = 1) {
    return this
      .http
      .get(environment.apiUrl + '/countries?page=' + page)
      .pipe(
        map((raw: PaginationResponse<Country>) => {
          return raw.response;
        })
      );
  }

  public getOne(id) {
    return this
      .http
      .get(environment.apiUrl + '/countries/' + id)
      .pipe(
        map((raw: DetailResponse<Country>) => {
          return raw.response;
        })
      );
  }

  public deleteOne(id) {
    return this
      .http
      .delete(environment.apiUrl + '/countries/' + id);
  }
}
