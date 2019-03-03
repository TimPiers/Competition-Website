import { BaseModel } from './base.model';
import { Game } from './game.model';
import { Prize } from './prize.model';

export interface Competition extends BaseModel {

  Id: number;
  Title: string;
  Description: string;
  StartDate: Date;
  EndtDate: Date;
  Status: number;

  GameId: number;
  Game: Game;

  PrizeId: number;
  Prize: Prize;

  Players: string[];
  Winners: string[];
}
