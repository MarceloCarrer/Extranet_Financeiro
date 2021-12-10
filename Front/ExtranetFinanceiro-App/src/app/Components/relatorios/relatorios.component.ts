import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Relatorio } from '../../models/Relatorio';
import { RelatorioService } from '../../services/relatorio.service';
import { PoloRelatoriosComponent } from '../polo-relatorios/polo-relatorios.component';

@Component({
  selector: 'app-relatorios',
  templateUrl: './relatorios.component.html',
  styleUrls: ['./relatorios.component.scss']
})
export class RelatoriosComponent implements OnInit {

  public relatorios: Relatorio[] = [];
  public relatoriosFiltrados: Relatorio[] = [];
  private _filtroLista: string = '';
  public poloRelatorios = {} as PoloRelatoriosComponent;

  public get filtroLista() {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.relatoriosFiltrados = this.filtroLista ? this.filtrarRelatorios(this.filtroLista) : this.relatorios;
  }

  public filtrarRelatorios(filtrarPor: string): Relatorio[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.relatorios.filter(
      (relatorio: any) => relatorio.mes.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      relatorio.ano.toLocaleLowerCase().indexOf(filtrarPor) !== -1
      );
    }

    constructor(
      private relatorioService: RelatorioService,
      private toastr: ToastrService,
      private spinner: NgxSpinnerService,
      private router: Router,
      ) { }

      public ngOnInit(): void {
        this.spinner.show();
        this.getRelatorios();
      }

      public getRelatorios(): void {
        const observer = {
          next: (_relatorios: Relatorio[]) => {
            this.relatorios = _relatorios;
            this.relatoriosFiltrados = this.relatorios;
          },
          error: (error: any) => {
            console.error(error);
            this.spinner.hide();
            this.toastr.error('Informações não carregadas.', 'Erro!');

          },
          complete: () => this.spinner.hide()
        };
        this.relatorioService.getRelatorios().subscribe(observer)
      };

      public getPolos(relatorioId: number): void {
        this.router.navigate([`polo-relatorios/${relatorioId}`]);
      }
}


