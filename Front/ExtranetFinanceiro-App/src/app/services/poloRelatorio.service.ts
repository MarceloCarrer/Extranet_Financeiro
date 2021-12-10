import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PoloRelatorio } from '../models/PoloRelatorio';
import { take } from 'rxjs/operators';

@Injectable()

export class PoloRelatorioService {

baseURL = environment.apiURL + 'api/poloRelatorios';

constructor(
  private http: HttpClient
  ) { }

  public getPoloByRelatorioId(relatorioId: number): Observable<PoloRelatorio[]> {
    return this.http.get<PoloRelatorio[]>(`${this.baseURL}/relatorioId/${relatorioId}`).pipe(take(1));
  }

  public getPoloId(id: number): Observable<PoloRelatorio> {
    return this.http.get<PoloRelatorio>(`${this.baseURL}/${id}`).pipe(take(1));
  }

  public getPoloByNome(nome: string): Observable<PoloRelatorio> {
    return this.http.get<PoloRelatorio>(`${this.baseURL}/nome/${nome}`).pipe(take(1));
  }

}
