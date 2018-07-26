import { Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})

export class TweetService {
  constructor(private http: HttpClient) {
  }

  getAllTweets(): Observable<any> {
    return this.http.get<any>('http://localhost:7000/api/tweets/GetAllTweets');
  }

  getUserTweetCount(id: number): Observable<any> {
    return this.http.get<any>('http://localhost:7000/api/tweets/GetUserTweetCount/' + id);
  }

  tweet(content:string, id: number): Observable<any> {
    return this.http.post<any>(
      'http://localhost:7000/api/tweets/AddTweet/',
      {
              'content': content,
              'userId': id,
            }
      );
  }

  deleteTweet(id: number): Observable<any> {
    return this.http.delete<any>(
      'http://localhost:7000/api/tweets/DeleteTweet/' + id);
  }
}


