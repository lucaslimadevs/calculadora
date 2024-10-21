import { Component } from '@angular/core';
import { CdbDto } from '../models/cdb-dto.model';
import { CdbService } from '../services/cdb.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-calculadora-cdb',
  templateUrl: './calculadora-cdb.component.html',
  styleUrl: './calculadora-cdb.component.css'
})
export class CalculadoraCdbComponent {
  valorInicial: number | null = null;
  prazoMeses: number | null = null;
  resultado: CdbDto | null = null;

  constructor(private cdbService: CdbService, private toastr: ToastrService) {}

  calcular() {
    if (this.valorInicial === null || this.prazoMeses === null) {
      this.toastr.error('Por favor, preencha todos os campos.');
      return;
    }

    if (this.valorInicial <= 0) {
      this.toastr.error('O valor inicial deve ser maior que 0.');
      return;
    }

    if (this.prazoMeses <= 0) {
      this.toastr.error('O prazo deve ser maior que 0.');
      return;
    }

    this.cdbService.calcularCdb(this.valorInicial, this.prazoMeses).subscribe(
      (data) => {
        this.resultado = data;
      },
      (error) => {
        console.error('Erro ao calcular CDB', error);
      }
    );
  }

}
