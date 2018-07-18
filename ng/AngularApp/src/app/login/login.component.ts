import {Component, ViewChild} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'login-form',
  templateUrl: './login.component.html'
})

export class LoginComponent {
  model: any = {};

  constructor(private http: HttpClient){}

  //angular object
  //@ViewChild('email') emailVc;

  onSubmit() {
    console.log('Value submitted');
  }
}
