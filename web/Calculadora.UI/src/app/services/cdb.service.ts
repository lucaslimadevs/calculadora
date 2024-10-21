import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CdbDto } from '../models/cdb-dto.model';

@Injectable({
  providedIn: 'root',
})
export class CdbService {
  private apiUrl = 'http://localhost:5200/api/cdb';

  constructor(private http: HttpClient) {}

  calcularCdb(valorInicial: number, prazoMeses: number): Observable<CdbDto> {
    return this.http.post<CdbDto>(`${this.apiUrl}/calcular`, { valorInicial, prazoMeses });
  }
}