import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { Badge } from '../../shared/models/badge.model';

@Injectable({
  providedIn: 'root'
})
export class BadgeService extends BaseService {

  constructor(private httpClient: HttpClient) {
    super();
  }

  getAllBadges() {
    return this.httpClient.get<Array<Badge>>(`${this.env.webApi}/badges/all`);
  }

  saveBadge(badge: Badge) {
    return this.httpClient.post<Badge>(`${this.env.webApi}/badges/save`, badge);
  }

  deleteBadge(badge: Badge) {
    return this.httpClient.post<Badge>(`${this.env.webApi}/badges/delete`, badge);
  }
}
