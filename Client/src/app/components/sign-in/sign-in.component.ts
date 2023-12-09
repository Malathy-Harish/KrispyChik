import { Component } from '@angular/core';
import { Auth } from 'src/app/model/Auth';
import {  User } from 'src/app/model/User';
import { ProjectService } from 'src/app/services/project.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.scss']
})
export class SignInComponent {

  constructor(private service: ProjectService){}
  usr : User = new User();
  
  submit(): void{
    this.service.SignIn(this.usr.UserName,this.usr.Password).subscribe(
      {
        next: (e: Auth) => {
          console.log(e.token)
          

        }
      }
    )
    
  }
   

}
