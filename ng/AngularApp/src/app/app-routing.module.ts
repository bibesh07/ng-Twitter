import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { RegisterComponent} from './register/register.component';
import {AppLoginRegisterLinkComponent} from './shared/app-login-register-link';
import {HomeComponent} from './home/home.component';
import {TweetComponent} from './tweet/tweet.component';
import {LoginTemplateComponent} from './shared/login-template/login-template.component';
import {AuthGuard} from './_guards';

const routes: Routes = [
  {path: '', component: IndexComponent, children: [
    {path: '', component: AppLoginRegisterLinkComponent}, {path: 'register', component: RegisterComponent}
    ]},
  {path: 'home', component: LoginTemplateComponent, canActivate: [AuthGuard], children: [
      {path: '', component: HomeComponent}
    ]},
  {path: 'tweet', component: TweetComponent}
  ];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
