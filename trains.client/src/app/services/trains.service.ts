import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { ITrain } from "../models/train";
import { IStation } from "../models/station";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})

export class TrainsService {
  constructor(private http: HttpClient) { }


  getTrains(): Observable<any[]> {
    return this.http.get<any[]>("api/trains/");
  }

  //todo refactor

  getDetails(): Observable<ITrain[]> {
    return this.http.get<ITrain[]>("api/store/details");
  }

  getStrorekeepers(): Observable<IStation[]> {
    return this.http.get<IStation[]>("api/store/storekeepers");
  }

  postDetail(detail: IStation) {
    return this.http.post("api/store/detail/", detail, { observe: 'response', headers: new HttpHeaders({ 'Content-Type': 'application/json' }) });
  }

  postStorekeeper(storekeeper: ITrain) {
    return this.http.post("api/store/storekeeper/", storekeeper, { observe: 'response', headers: new HttpHeaders({ 'Content-Type': 'application/json' }) });

  }

  deleteStorekeeper(id: number) {
    return this.http.delete("api/store/storekeeper/" + id, { observe: 'response' });

  }

  deleteDetail(id: number) {
    return this.http.delete("api/store/detail/" + id, { observe: 'response' });
  }

}
