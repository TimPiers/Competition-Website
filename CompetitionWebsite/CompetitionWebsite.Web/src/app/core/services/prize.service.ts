import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { Prize } from '../../shared/models/prize.model';

@Injectable({
  providedIn: 'root'
})
export class PrizeService extends BaseService {

  constructor(private httpClient: HttpClient) {
    super();
  }

  savePrize(prize: Prize) {
    return this.httpClient.post<Prize>(`${this.env.webApi}/prizes/save`, prize);
  }

}
