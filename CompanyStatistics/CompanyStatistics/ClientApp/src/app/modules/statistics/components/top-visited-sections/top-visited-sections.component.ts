import { Component, Input, OnInit } from '@angular/core';
import { SectionVisitsStatistics } from '../../models/section-visits-statistics';
import { StatisticsService } from '../../services/statistics.service';

@Component({
  selector: 'app-top-visited-sections',
  templateUrl: './top-visited-sections.component.html',
  styleUrls: ['./top-visited-sections.component.scss']
})
export class TopVisitedSectionsComponent implements OnInit {
  @Input() limit: number = 3;
  @Input() sectionsStatistics: SectionVisitsStatistics[] = []

  constructor() { }

  ngOnInit(): void {
  }

}
