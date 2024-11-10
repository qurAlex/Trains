import { Component, OnInit } from "@angular/core";
import { TrainsService } from "../../services/trains.service";

@Component({
  selector: 'add-station',
  templateUrl: './add-station.component.html',
  styleUrl: './add-station.component.css'
})
export class AddStationComponent implements OnInit {

  constructor(private trainsService: TrainsService) { }

  ngOnInit() {
    this.getTrains();
  }

  getTrains() {

  }
}
