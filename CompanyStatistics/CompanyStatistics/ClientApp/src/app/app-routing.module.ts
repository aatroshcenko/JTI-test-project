import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SectionsComponent } from './components/sections/sections.component';
import { StatisticsComponent } from './modules/statistics/statistics.component';

const routes: Routes = [
  { path: 'home', component: SectionsComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'statistics', component: StatisticsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
