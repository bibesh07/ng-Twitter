import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { RegisterComponent} from './register/register.component';
import {AppLoginRegisterLinkComponent} from './shared/app-login-register-link';

const routes: Routes = [
  {path: '', component: IndexComponent, children: [
    {path: '', component: AppLoginRegisterLinkComponent}, {path: 'register', component: RegisterComponent}
    ]}
  ];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
