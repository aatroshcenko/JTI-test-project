import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { SectionVisitsStatistics } from '../models/section-visits-statistics';
import { UserVisitsStatistics } from '../models/user-visits-statistics';


@Injectable({
  providedIn: 'root'
})
export class StatisticsService {

  constructor( private httpClient: HttpClient) { }

  getSectionsVisitStatistics(limit: number): Observable<SectionVisitsStatistics[]>{
    return this.httpClient.get<SectionVisitsStatistics[]>(
      environment.apiUrl + 'statistics/sectionsVisit?limit='+limit);
  }

  getUsersVisitStatistics(limit: number): Observable<UserVisitsStatistics[]>{
    return this.httpClient.get<UserVisitsStatistics[]>(
      environment.apiUrl + 'statistics/usersVisit?limit='+limit);
  }
}
