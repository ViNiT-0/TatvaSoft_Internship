import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [HeaderComponent,RouterOutlet,CommonModule,FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  name = 'GEC';
  user='UserOne';
  visibility=true;
  list=['one','two','three',1,2,3];
  store='default';
  listner(){
    // console.log("btn clicked");
    this.visibility=!this.visibility;
    console.log(this.store);
  }
}
