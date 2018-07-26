import {Component} from '@angular/core';
import {UserService} from '../_services/user.service';
import {NgForm} from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: 'register.component.html',
  styleUrls: ['register.component.css']
})

export class RegisterComponent {
  title = 'Register';
  message = '';
  type = '';

  constructor(
    private userService: UserService
  ) {}

  model: any = {};

  onSubmit(form: NgForm) {
    this.userService.register(this.model)
      .subscribe(response => {
       this.message = response.message;
       this.type = response.type;
       if (response.type === 'success') {
         form.resetForm();
       }
      });
  }
}
