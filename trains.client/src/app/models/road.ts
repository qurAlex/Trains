import { IDirection } from "./direction";
import { ITrain } from "./train";

export interface IRoad {
  Id: number;
  Name: string;
  Description: string;
  DirectionId: number;
  Direction: IDirection;
  Trains: ITrain[];
}
