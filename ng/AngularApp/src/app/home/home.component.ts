import { Component, OnInit } from '@angular/core';
import {UserService} from '../_services/user.service';
import { User} from '../models/user';
import {TweetService} from "../_services/tweet.service";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  currentUser: User;
  allTweets: any[];

  constructor(
    private userService: UserService,
    private tweetService: TweetService,
  ) { }

  ngOnInit() {
    this.load_user_data();
    this.load_all_tweets();
    }

    load_user_data(): void {
      this.userService.getUser(parseInt(localStorage.getItem('user_id'), 10))
        .subscribe(response => {
          this.currentUser = response;
        });
    }

    load_all_tweets(): void {
      this.tweetService.getAllTweets()
        .subscribe(response => {
          console.log(response);
          this.allTweets = response;
        })
    }
}
