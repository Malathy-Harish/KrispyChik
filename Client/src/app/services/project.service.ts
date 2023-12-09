import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {
  

  constructor(private http: HttpClient) { }

  SignIn(UserName: string, Password: string): Observable<string>
  {
    return this.http.get<any>("https://localhost:7263/api/Auth/SignIn",{
      params:{
        "username": UserName,
        "password": Password
      }
    })
  }
}
