import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SectionsComponent } from './components/sections/sections.component';
import { StatisticsModule } from './modules/statistics/statistics.module';
import { SectionsService } from './services/sections.service';

import { TuiTabsModule } from '@taiga-ui/kit';
import { TuiRootModule } from '@taiga-ui/core';
import { TuiActionModule } from '@taiga-ui/kit';

@NgModule({
  declarations: [
    AppComponent,
    SectionsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    StatisticsModule,
    TuiTabsModule,
    TuiRootModule,
    TuiActionModule,
    HttpClientModule
  ],
  providers: [
    SectionsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
