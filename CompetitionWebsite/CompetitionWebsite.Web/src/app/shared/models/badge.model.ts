import { BaseModel } from './base.model';

export interface Badge extends BaseModel {

  Id: number;
  Title: string;
  IconPath: string;

  Players: string[];

}
