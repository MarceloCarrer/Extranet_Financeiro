import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Relatorio } from '../models/Relatorio';
import { take } from 'rxjs/operators';

@Injectable()

export class RelatorioService {

  baseURL = environment.apiURL + 'api/relatorios';

  constructor(
    private http: HttpClient
    ) { }

    public getRelatorios(): Observable<Relatorio[]> {
      return this.http.get<Relatorio[]>(this.baseURL).pipe(take(1));
    }

    public getRelatorioById(id: number): Observable<Relatorio> {
      return this.http.get<Relatorio>(`${this.baseURL}/${id}`).pipe(take(1));
    }
  }
