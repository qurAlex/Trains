import { Component, OnInit } from "@angular/core";
import { TrainsService } from "../../services/trains.service";

@Component({
  selector: 'app-train',
  templateUrl: './train.component.html',
  styleUrl: './train.component.css'
})
export class TrainComponent implements OnInit {

  constructor(private trainsService: TrainsService) { }

  ngOnInit() {
    this.getTrains();
  }

  getTrains() {

  }
}
