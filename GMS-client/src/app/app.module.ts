import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {FormsModule} from "@angular/forms";
import { Page2Component } from './page2/page2.component';
import { Page3Component } from './page3/page3.component';
import {NgOptimizedImage} from "@angular/common";
import {HttpClientModule} from "@angular/common/http";
import { Page4Component } from './page4/page4.component';
import { Page4frontendComponent } from './page4frontend/page4frontend.component';

@NgModule({
  declarations: [
    AppComponent,
    Page2Component,
    Page3Component,
    Page4Component,
    Page4frontendComponent
  ],
    imports: [
        BrowserModule,
        FormsModule,
        NgOptimizedImage,
      HttpClientModule
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
