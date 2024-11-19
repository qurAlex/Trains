import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ITrain } from "../models/train";
import { IStation } from "../models/station";
import { Observable } from "rxjs";
import { IDirection } from "../models/direction";

@Injectable({
  providedIn: 'root'
})

export class TrainsService {
  constructor(private http: HttpClient) { }


  getTrains(): Observable<ITrain[]> {
    return this.http.get<ITrain[]>("api/trains/getTrains");
  }

  getTrain(id: number): Observable<ITrain> {
    return this.http.get<ITrain>("api/trains/getTrain?id=" + id);
  }

  addTrain(train: ITrain) {
    return this.http.post("api/trains/addTrain", train);
  }

  getStations(): Observable<IStation[]> {
    return this.http.get<IStation[]>("api/trains/getStations");
  }

  addStation(station: IStation) {
    return this.http.post("api/trains/addStation", station);
  }


  getDirections(): Observable<IDirection[]> {
    return this.http.get<IDirection[]>("api/trains/getDirections");
  }

  addDirection(direction: IDirection) {
    return this.http.post("api/trains/addDirection", direction);
  }
}
