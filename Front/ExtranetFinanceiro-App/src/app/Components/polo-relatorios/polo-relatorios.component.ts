import { Component, OnInit, TemplateRef } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PoloTurma } from 'src/app/models/PoloTurma';
import { PoloTurmaService } from 'src/app/services/poloTurma.service';
import { PoloRelatorio } from '../../models/PoloRelatorio';
import { PoloRelatorioService } from '../../services/poloRelatorio.service';

@Component({
  selector: 'app-polo-relatorios',
  templateUrl: './polo-relatorios.component.html',
  styleUrls: ['./polo-relatorios.component.scss']
})
export class PoloRelatoriosComponent implements OnInit {

  public poloRelatorios: PoloRelatorio[] = [];
  public polosFiltrados: PoloRelatorio[] = [];
  private _filtroLista: string = '';
  public modalRef?: BsModalRef;
  public poloTurmas: PoloTurma[] = [];
  public polo: string = '';

  public get filtroLista() {
    return this._filtroLista;
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.polosFiltrados = this.filtroLista ? this.filtrarPolo(this.filtroLista) : this.poloRelatorios;
  }


  public filtrarPolo(filtrarPor: string): PoloRelatorio[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.poloRelatorios.filter(
      (poloRelatorios: any) => poloRelatorios.nome.toLocaleLowerCase()
                                                  .indexOf(filtrarPor) !== -1
      );
    }

  constructor(
    private poloRelatorioService: PoloRelatorioService,
    private poloTurmaService: PoloTurmaService,
    private activateRouter: ActivatedRoute,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService,
    private modalService: BsModalService
  ) { }

  public ngOnInit(): void {
    this.loadRelatorio();
  }

  public loadRelatorio(): void {
    const retatorioId = this.activateRouter.snapshot.paramMap.get('relatorioId');
    if (retatorioId !== null) {
      this.spinner.show();
      const observer = {
        next: (_polos: PoloRelatorio[]) => {
          this.poloRelatorios = _polos;
          this.polosFiltrados = this.poloRelatorios;
        },
        error: (error: any) => {
          this.spinner.hide();
          this.toastr.error('Informações não carregadas.', 'Erro!');
        },
        complete: () => this.spinner.hide()
      };
      this.poloRelatorioService.getPoloByRelatorioId(+retatorioId).subscribe(observer)
    }
  }

  openModal(template: TemplateRef<any>, poloId: number, poloNome: string): void {
    this.modalRef = this.modalService.show(template, { class: 'modal-xl' });
    this.polo = poloNome;
    this.loadTurma(poloId);
  }

  public loadTurma(poloId: number): void {
    if (poloId !== null) {
      this.spinner.show();
      const observer = {
        next: (_turmas: PoloTurma[]) => {
          this.poloTurmas = _turmas;
          this.poloTurmas = this.poloTurmas;
        },
        error: (error: any) => {
          console.error(error);
          this.spinner.hide();
          this.toastr.error('Informações não carregadas.', 'Erro!');
        },
        complete: () => this.spinner.hide()
      };
      this.poloTurmaService.getTurmaByPoloId(poloId).subscribe(observer)
    }
  }
}
