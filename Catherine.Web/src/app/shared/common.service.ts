import { Injectable } from '@angular/core';
import { SpinnerService } from './spinner.service';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class CommonService {
  constructor(
      public spinner: SpinnerService,
      public toastr: ToastrService
  ) { }

  public success(msg = '') {
    return this.toastr.success(msg);
  }

  public error(msg = '') {
    return this.toastr.error(msg);
  }
}
