import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {CounterComponent} from './counter/app.counter';
import { AngularFontAwesomeModule } from 'angular-font-awesome';
import {LoginComponent} from './login/login.component';
import {FormsModule} from '@angular/forms';
import {RegisterComponent} from './register/register.component';
import {HttpClient, HttpClientModule} from '@angular/common/http';
import { AppLoginRegisterLinkComponent } from './shared/app-login-register-link';
import { IndexComponent } from './index/index.component';
import { HomeComponent } from './home/home.component';
import { TweetComponent } from './tweet/tweet.component';
import { LoginTemplateComponent } from './shared/login-template/login-template.component';

@NgModule({
  declarations: [
    AppComponent,
    CounterComponent,
    LoginComponent,
    RegisterComponent,
    AppLoginRegisterLinkComponent,
    IndexComponent,
    HomeComponent,
    TweetComponent,
    LoginTemplateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFontAwesomeModule,
    FormsModule,
    HttpClientModule,
  ],
  providers: [HttpClient],
  bootstrap: [AppComponent]
})
export class AppModule { }
