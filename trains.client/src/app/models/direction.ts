import { IStation } from "./station";

export interface IDirection {
  Id: number;
  Name: string;
  StartStationId: number;
  EndStationId: number;
  Stations: IStation[];
}
