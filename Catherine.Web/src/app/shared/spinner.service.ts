import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SpinnerService {

  public show() {
      document.getElementById('spinner').classList.remove('hidden');
  }

  public hide() {
    document.getElementById('spinner').classList.add('hidden');
  }
}
