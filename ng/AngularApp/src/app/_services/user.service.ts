import { Injectable} from '@angular/core';
import {Observable, of} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {catchError} from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})

export class UserService {
  constructor(private http: HttpClient) {
  }
    Login(email: string, password: string) {
      return this.http.post<any>(
        'http://localhost:7000/api/users/login',
        {'Email': email, 'Password': password});
    }

    Logout(): void {
      localStorage.removeItem('user_id');
    }

    getUser(id: number): Observable<any> {
      return this.http.get<any>('http://localhost:7000/api/users/GetUserById/' + id);
    }

    register(user: any): Observable<any> {
      console.log(user);
      return this.http.post<any>(
        'http://localhost:7000/api/users/register',
        {
          'Email': user.email,
          'Password': user.password,
          'Username': user.username,
          'Name': user.name,
          'Phone': user.phone,
          'Bio': user.bio,
        }
        );
    }
}

