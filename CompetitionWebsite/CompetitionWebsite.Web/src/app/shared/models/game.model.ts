import { BaseModel } from './base.model';

export interface Game extends BaseModel {

  Id: number;
  Name: string;
  Description: string;
  ReleaseYear: Date;

  Competitions: string[];

}
