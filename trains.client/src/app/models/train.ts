import { Time } from "@angular/common";
import { IRoad } from "./road";
import { ISchedule } from "./schedule";


export interface ITrain {
  Id: number;
  Number: number;
  RoadId: number;
  Road: IRoad;
  StartTime: Time;
  TrainDate: Date[];
  Schedules: ISchedule[];
}
