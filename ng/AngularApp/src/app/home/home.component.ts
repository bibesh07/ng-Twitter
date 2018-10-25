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
  currentUser: any;
  allTweets: any[];
  totalUserTweets: number;
  content:string;
  current_user_id = parseInt(localStorage.getItem('user_id'), 10);

  constructor(
    private userService: UserService,
    private tweetService: TweetService,
  ) { }

  ngOnInit() {
    this.load_user_data();
    this.load_all_tweets();
    this.getUserTweetCount();
    }

    load_user_data(): void {
      this.userService.getUser(this.current_user_id)
        .subscribe(response => {
          this.currentUser = response;
        });
    }

    load_all_tweets(): void {
      this.tweetService.getAllTweets()
        .subscribe(response => {
          this.allTweets = response;
        });
    }

    getUserTweetCount(): void {
      this.tweetService.getUserTweetCount(this.current_user_id)
        .subscribe(response => {
          this.totalUserTweets = response;
        });
    }

    tweet(): void {
      this.tweetService.tweet(this.content, this.current_user_id)
        .subscribe(response => {
          this.content = '';
          this.ngOnInit();
        });
    }

    deleteTweet($event): void {
    console.log($event.target.value);
      this.tweetService.deleteTweet($event.target.value, this.current_user_id)
        .subscribe(response => {
          this.ngOnInit();
        });
    }
}

