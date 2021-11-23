import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-relatorios',
  templateUrl: './relatorios.component.html',
  styleUrls: ['./relatorios.component.scss']
})
export class RelatoriosComponent implements OnInit {

  public relatorios: any = [];
  public relatoriosFiltrados: any = [];
  private _filtroLista: string = '';

  public get filtroLista() {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.relatoriosFiltrados = this.filtroLista ? this.filtrarRelatorios(this.filtroLista) : this.relatorios;
  }

  public filtrarRelatorios(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.relatorios.filter(
      (relatorio: any) => relatorio.mes.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
                          relatorio.ano.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  constructor(
    private http: HttpClient
  ) { }

  ngOnInit(): void {
    this.getRelatorios();
  }

  public getRelatorios(): void {
    this.http.get('https://localhost:5001/api/relatorios').subscribe(
      response => {
        this.relatorios = response;
        this.relatoriosFiltrados = this.relatorios
      },
      error => console.log(error)
    );
  }

}
