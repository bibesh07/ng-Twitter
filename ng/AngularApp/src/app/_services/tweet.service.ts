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
}


