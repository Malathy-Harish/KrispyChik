import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { SignUpComponent } from './components/sign-up/sign-up.component';


const routes: Routes = [
  {
    path:'signin', component: SignInComponent
  },
  {
    path:'signup', component: SignUpComponent
  },
  {
    path:' ', redirectTo:'/signin', pathMatch:'full'
  },
  {
    path:'**', redirectTo:'/signin',pathMatch:'full'
  }
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
