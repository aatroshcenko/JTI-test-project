import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StatisticsComponent } from './statistics.component';
import { TopActiveUsersComponent } from './components/top-active-users/top-active-users.component';
import { TopVisitedSectionsComponent } from './components/top-visited-sections/top-visited-sections.component';
import { StatisticsService } from './services/statistics.service';
import { TuiAvatarModule } from '@taiga-ui/kit';
import { TuiResizableColumnModule } from '@taiga-ui/addon-table/components/resizable-column';



@NgModule({
  declarations: [
    StatisticsComponent,
    TopActiveUsersComponent,
    TopVisitedSectionsComponent
  ],
  imports: [
    CommonModule,
    TuiAvatarModule,
    TuiResizableColumnModule
  ],
  exports: [
    StatisticsComponent
  ],
  providers: [
    StatisticsService
  ]
})
export class StatisticsModule { }
