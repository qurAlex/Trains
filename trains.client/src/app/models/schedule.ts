import { Time } from "@angular/common";
import { IStation } from "./station";
import { ITrain } from "./train";


export interface ISchedule {
  Id: number;
  Name: string;
  TimeOnStation: Time;
  TimeOutStation: Time;
  StopTime: Time;
  StationId: number;
  Station: IStation;
  Trains: ITrain[];
}
