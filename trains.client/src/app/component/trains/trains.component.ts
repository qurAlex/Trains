import { Component, OnInit } from "@angular/core";
import { TrainsService } from "../../services/trains.service";
import { ITrain } from "../../models/train";

@Component({
  selector: 'app-trains',
  templateUrl: './trains.component.html',
  styleUrl: './trains.component.css'
})
export class TrainsComponent implements OnInit {

  public trains: ITrain[] = [];

  constructor(private trainsService: TrainsService) { }

  ngOnInit() {
    this.getTrains();
  }

  getTrains() {
    this.trainsService.getTrains().subscribe(
      (result) => {
        this.trains = result;
        console.log(this.trains);
      },
      (error) => {
        console.error(error);
      }
    );
  }
}
