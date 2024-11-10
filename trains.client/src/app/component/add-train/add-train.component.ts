import { Component, OnInit } from "@angular/core";
import { TrainsService } from "../../services/trains.service";

@Component({
  selector: 'add-train',
  templateUrl: './add-train.component.html',
  styleUrl: './add-train.component.css'
})
export class AddTrainComponent implements OnInit {

  constructor(private trainsService: TrainsService) { }

  ngOnInit() {
    this.getTrains();
  }

  getTrains() {

  }
}
