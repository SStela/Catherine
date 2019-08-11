import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Country } from './country';
import { map } from 'rxjs/operators';
import { ApiResponse } from '../shared/Response/ApiResponse';

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
        map((raw: ApiResponse<Country>) => {
          return raw.response;
        })
      );
  }

  public getOne(id) {
    return this
      .http
      .get(environment.apiUrl + '/countries/' + id)
      .pipe(
        map((raw: ApiResponse<Country>) => {
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
