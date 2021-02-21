import { Component, OnInit } from '@angular/core';
import { SectionVisitsStatistics } from './models/section-visits-statistics';
import { UserVisitsStatistics } from './models/user-visits-statistics';
import { StatisticsService } from './services/statistics.service';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.scss']
})
export class StatisticsComponent implements OnInit {

  sectionsCount: number = 3;
  usersCount: number = 10;

  sectionsStatistics: SectionVisitsStatistics[] = [
    {
      section: {
        sectionId: 1,
        name: 'Section1'
      },
      totalVisitsCount: 10
    },
    {
      section: {
        sectionId: 2,
        name: 'Section2'
      },
      totalVisitsCount: 9
    }
  ]
  usersStatistics: UserVisitsStatistics[] = [
    {
      user: {
        userId: 1,
        firstName: 'FirstName',
        lastName: 'LastName'
      },
      totalVisitsCount: 10,
      favoriteSection: {
        sectionId: 1,
        name: 'Section1'
      }
    }
  ] 

  constructor(private statisticsService: StatisticsService) { }

  ngOnInit(): void {
    this.statisticsService
    .getSectionsVisitStatistics(this.sectionsCount)
    .subscribe(sections => this.sectionsStatistics = sections);

    this.statisticsService
    .getUsersVisitStatistics(this.usersCount)
    .subscribe(users => this.usersStatistics = users);
  }

}
