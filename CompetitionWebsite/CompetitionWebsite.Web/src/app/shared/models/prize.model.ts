import { BaseModel } from './base.model';

export interface Prize extends BaseModel {

  Id: number;
  Title: string;
  Description: string;
  BadgeId: number;


}
