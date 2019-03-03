import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { Badge } from '../../shared/models/badge.model';
import { Competition } from '../../shared/models/competition.model';

@Injectable({
  providedIn: 'root'
})
export class CompetitionService extends BaseService {

  constructor(private httpClient: HttpClient) {
    super();
  }

  getAllCompetitions() {
    return this.httpClient.get<Array<Competition>>(`${this.env.webApi}/competitions/all`);
  }

  saveCompetition(competition: Competition) {
    return this.httpClient.post<Competition>(`${this.env.webApi}/competitions/save`, competition);
  }

  deleteCompetition(competition: Competition) {
    return this.httpClient.post<Competition>(`${this.env.webApi}/competitions/delete`, competition);
  }
}
