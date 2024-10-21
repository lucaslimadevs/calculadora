import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CalculadoraCdbComponent } from './calculadora-cdb/calculadora-cdb.component';

const routes: Routes = [
  { path: '', component: CalculadoraCdbComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
