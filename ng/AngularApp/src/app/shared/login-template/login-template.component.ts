import { Component, OnInit } from '@angular/core';
import {UserService} from '../../_services/user.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-login-template',
  templateUrl: './login-template.component.html',
  styleUrls: ['./login-template.component.scss']
})
export class LoginTemplateComponent implements OnInit {

  currentUser: any;
  current_user_id = parseInt(localStorage.getItem('user_id'), 10);

  constructor(
    private userService: UserService,
    private router: Router,
  ) { }

  ngOnInit() {
    this.load_user_data();
  }

  load_user_data(): void {
    this.userService.getUser(this.current_user_id)
      .subscribe(response => {
        this.currentUser = response;
      });
  }

  logOut() {
    this.userService.Logout();
    this.router.navigate(['/']);
  }

}
