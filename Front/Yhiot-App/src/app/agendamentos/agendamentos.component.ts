import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-agendamentos',
  templateUrl: './agendamentos.component.html',
  styleUrls: ['./agendamentos.component.scss']
})
export class AgendamentosComponent implements OnInit {
  constructor(private http: HttpClient){}

  ngOnInit(): void {
    this.getEventos();

  }
  public agendamento: any;

  public getEventos(): void {
    this.http.get('http://localhost:5069/api/fracasso').subscribe(
      response => this.agendamento = response
    );

  }
}


