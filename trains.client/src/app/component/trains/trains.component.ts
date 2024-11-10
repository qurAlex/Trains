import { Component, OnInit } from "@angular/core";
import { TrainsService } from "../../services/trains.service";

@Component({
  selector: 'app-trains',
  templateUrl: './trains.component.html',
  styleUrl: './trains.component.css'
})
export class TrainsComponent implements OnInit {

  constructor(private trainsService: TrainsService) { }

  ngOnInit() {
    this.getTrains();
  }

  getTrains() {

  }
}
