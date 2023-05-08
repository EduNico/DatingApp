import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../_models/user';
import { map } from 'rxjs/operators';
import { BehaviorSubject } from 'rxjs';




@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = 'https://localhost:7280/api/';
  private currentUserSource = new BehaviorSubject<User| null>(null); // union type, a thing can be made of one or more types.
  currentUser$ = this.currentUserSource.asObservable();          //$ indicate that is an observable
  constructor(private http:HttpClient) { }

  login(model: any){
    return this.http.post<User>(this.baseUrl + 'account/login',model).pipe(
      map((response: User) => {
        const user =response;
        if (user) {
          localStorage.setItem('user',JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
    )
  }

  register(model: any){
    return this.http.post<User>(this.baseUrl + 'account/register', model).pipe(map(user => {
      if (user){
        localStorage.setItem('user', JSON.stringify(user));
        this.currentUserSource.next(user);
      }
    }))
  }

  setCurrentUser(user: User){
    this.currentUserSource.next(user);
  }

  logout( ){
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
  }
}
