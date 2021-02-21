import { Component, OnInit } from '@angular/core';
import { Section } from 'src/app/models/section';
import { SectionsService } from 'src/app/services/sections.service';

@Component({
  selector: 'app-sections',
  templateUrl: './sections.component.html',
  styleUrls: ['./sections.component.scss']
})
export class SectionsComponent implements OnInit {
  sections: Section[] = [
    {
      sectionId: 1,
      name: 'Section1'
    },
    {
      sectionId: 2,
      name: 'Section2'
    }
  ];

  constructor(private sectionService: SectionsService) {}

  ngOnInit(): void {
    this.sectionService.getSections().subscribe(sections => this.sections = sections);
  }

}
