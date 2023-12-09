import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Auth } from '../model/Auth';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {
  

  constructor(private http: HttpClient) { }

  SignIn(UserName: string, Password: string): Observable<Auth>
  {
    return this.http.get<Auth>("https://localhost:44312/api/Auth/SignIn",{
      params:{
        "username": UserName,
        "password": Password
      }
    })
  }
}
