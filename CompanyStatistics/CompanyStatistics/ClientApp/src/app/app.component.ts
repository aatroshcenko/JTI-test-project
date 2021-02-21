import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {  	
  readonly tabs = [
    'Home',
    'Statistics',
  ];

  activeElement = String(this.tabs[0]);
  	
  get activeItemIndex(): number {
    return this.tabs.indexOf(this.activeElement);
  }
  	
  onClick(activeElement: string) {
    this.activeElement = activeElement;
  }
}
