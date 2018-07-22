import {Component} from '@angular/core';
import {UserService} from '../_services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-form',
  templateUrl: './login.component.html'
})

export class LoginComponent {
  model: any = {};

  errorMessage: string;

  constructor(
    private userService: UserService,
    private router: Router
  ) {}

  onSubmit() {
    this.userService.Login(this.model.email, this.model.password)
      .subscribe(response => {
        console.log(response);
        if (response > 0) {
          localStorage.setItem('user_id', response);
          this.router.navigate(['/home']);
        } else {
          this.errorMessage = 'Invalid Login Details';
        }
      });
  }
}
