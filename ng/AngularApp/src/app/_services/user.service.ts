import { Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})

export class UserService {
  constructor(private http: HttpClient) {
  }
    Login(email: string, password: string)  {
      return this.http.get<any>('/api/user/login');
    }
}
