import {Component, ViewChild} from '@angular/core';
import {UserService} from '../_services/user.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login.component.html'
})

export class LoginComponent {
  model: any = {};

  constructor(
    private userService: UserService) {}

  onSubmit() {
    this.userService.Login(this.model.email, this.model.password)
      .subscribe(response => {
        console.log('Login successfully');
      });
  }
}
