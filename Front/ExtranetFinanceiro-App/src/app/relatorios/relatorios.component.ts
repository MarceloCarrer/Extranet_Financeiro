import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-relatorios',
  templateUrl: './relatorios.component.html',
  styleUrls: ['./relatorios.component.scss']
})
export class RelatoriosComponent implements OnInit {

  public relatorios: any;

  constructor(
    private http: HttpClient
  ) { }

  ngOnInit(): void {
    this.getRelatorios();
  }

  public getRelatorios(): void {
    this.http.get('https://localhost:5001/api/relatorios').subscribe(
      response => this.relatorios = response,
      error => console.log(error)
    );
  }

}
