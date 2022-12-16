import { Component } from '@angular/core';
import { PrimeNGConfig } from 'primeng/api';

@Component({
  selector: 'app-root',
  template: `
    <router-outlet></router-outlet>
  `,
})
export class AppComponent {
  menuMode = 'static';
  constructor(private primengCofig:PrimeNGConfig){}
  ngOnInit(){
    this.primengCofig.ripple = true;
    document.documentElement.style.fontSize = '14px' 
  }
}
