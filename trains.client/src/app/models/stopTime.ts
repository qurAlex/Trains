import { Time } from "@angular/common";
import { IRoad } from "./road";
import { IStation } from "./station";


export interface IStopTime {
  Id: number;
  RoadId: number;
  Road: IRoad;
  StationId: number;
  Station: IStation;
  Time: Time;
}
