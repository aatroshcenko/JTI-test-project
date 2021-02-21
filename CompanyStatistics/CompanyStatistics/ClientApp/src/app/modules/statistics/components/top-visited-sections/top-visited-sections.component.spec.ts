import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopVisitedSectionsComponent } from './top-visited-sections.component';

describe('TopVisitedSectionsComponent', () => {
  let component: TopVisitedSectionsComponent;
  let fixture: ComponentFixture<TopVisitedSectionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopVisitedSectionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TopVisitedSectionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
