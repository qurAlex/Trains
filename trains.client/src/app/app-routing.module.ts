import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TrainsComponent } from './component/trains/trains.component';
import { TrainComponent } from './component/train/train.component';
import { AddTrainComponent } from './component/add-train/add-train.component';
import { AddStationComponent } from './component/add-station/add-station.component';
import { AddDirectionComponent } from './component/add-direction/add-direction.component';

const routes: Routes = [
  { path: 'trains', component: TrainsComponent },
  { path: 'train', component: TrainComponent },
  { path: 'add-train', component: AddTrainComponent },
  { path: 'add-station', component: AddStationComponent },
  { path: 'add-direction', component: AddDirectionComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
