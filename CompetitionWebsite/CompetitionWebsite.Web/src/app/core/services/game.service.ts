import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { Game } from '../../shared/models/game.model';

@Injectable({
  providedIn: 'root'
})
export class GameService extends BaseService {

  constructor(private httpClient: HttpClient) {
    super();
  }

  getAllGames() {
    return this.httpClient.get<Array<Game>>(`${this.env.webApi}/games/all`);
  }

  saveGame(game: Game) {
    return this.httpClient.post<Game>(`${this.env.webApi}/games/save`, game);
  }

  deleteGame(game: Game) {
    return this.httpClient.post<Game>(`${this.env.webApi}/games/delete`, game);
  }
}
