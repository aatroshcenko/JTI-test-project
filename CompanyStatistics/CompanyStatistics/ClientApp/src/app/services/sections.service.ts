import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Section } from '../models/section';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SectionsService {

  constructor( private httpClient: HttpClient) { }

  getSections(): Observable<Section[]>{
    return this.httpClient.get<Section[]>(environment.apiUrl + 'sections');
  }
}
