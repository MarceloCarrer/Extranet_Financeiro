import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PoloTurma } from '../models/PoloTurma';
import { take } from 'rxjs/operators';

@Injectable()

export class PoloTurmaService {

baseURL = environment.apiURL + 'api/poloTurmas';

constructor(
  private http: HttpClient
  ) { }

  public getTurmaByPoloId(poloRelatorioId: number): Observable<PoloTurma[]> {
    return this.http.get<PoloTurma[]>(`${this.baseURL}/poloRelatorioId/${poloRelatorioId}`).pipe(take(1));
  }

  public getTurmaId(id: number): Observable<PoloTurma> {
    return this.http.get<PoloTurma>(`${this.baseURL}/${id}`).pipe(take(1));
  }

  public geTurmaByDescricao(descricao: string): Observable<PoloTurma> {
    return this.http.get<PoloTurma>(`${this.baseURL}/descricao/${descricao}`).pipe(take(1));
  }

}
