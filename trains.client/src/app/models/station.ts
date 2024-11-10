import { IDirection } from "./direction";
import { ISchedule } from "./schedule";
import { IStopTime } from "./stopTime";

export interface IStation {
  Id: number;
  Number: number;
  Name: string;
  Type: number;
  StopTimes: IStopTime[];
  Directions: IDirection[];
  Schedules: ISchedule[];
}
