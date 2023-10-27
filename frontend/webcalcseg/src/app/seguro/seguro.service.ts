import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Seguro } from '../seguro/sguro.model';

@Injectable({
  providedIn: 'root',
})
export class SeguroService {
  private apiUrl = 'http://webcalsegapi.somee.com/api';

  constructor(private http: HttpClient) {}

  createSeguro(seguro: Seguro): Observable<Seguro> {
    return this.http.post<Seguro>(this.apiUrl + '/Gravar', seguro);
  }

  //https://localhost:7056/api/Pesquisar/fasfsd
  getSeguroByCPF(cpf: string): Observable<Seguro> {
    return this.http.get<Seguro>(`${this.apiUrl}/Pesquisar/${cpf}`);
  }

  //https://localhost:7056/api/Calcular/222
  getCalcular(valorVeiculo: number): Observable<Seguro> {
    return this.http.get<Seguro>(`${this.apiUrl}/Calcular/${valorVeiculo}`);
  }

  generateReport(): Observable<any> {
    console.log(`chmando... ${this.apiUrl}/Gerar`);
    return this.http.get<any>(`${this.apiUrl}/Gerar`);
  }
}
