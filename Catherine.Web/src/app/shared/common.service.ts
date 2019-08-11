import { Injectable } from '@angular/core';
import { SpinnerService } from './spinner.service';

@Injectable({
  providedIn: 'root'
})
export class CommonService {
  constructor(
      public spinner: SpinnerService
  ) { }
}
