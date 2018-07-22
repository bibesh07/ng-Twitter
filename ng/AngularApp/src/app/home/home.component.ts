import { Component, OnInit } from '@angular/core';
import {UserService} from '../_services/user.service';
import { User} from '../models/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  currentUser: User;
  constructor(
    private userService: UserService
  ) { }

  ngOnInit() {
    this.userService.getUser(parseInt(localStorage.getItem('user_id'), 10))
      .subscribe(response => {
        this.currentUser = response;
      });
    }
}
