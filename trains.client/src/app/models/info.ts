import { Time } from "@angular/common";

export interface IInfo {
  Id: number;
  CurrentStationId: number;
  NextStationId: number;
  TimeToNextStation: Time;
  Distance: number;
}
