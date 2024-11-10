import { Component, OnInit } from "@angular/core";
import { TrainsService } from "../../services/trains.service";

@Component({
  selector: 'add-direction',
  templateUrl: './add-direction.component.html',
  styleUrl: './add-direction.component.css'
})
export class AddDirectionComponent implements OnInit {

  constructor(private trainsService: TrainsService) { }

  ngOnInit() {
    this.getTrains();
  }

  getTrains() {

  }
}
