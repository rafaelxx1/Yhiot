import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{

  public agendamento: any;
  public agendamentoFilter: any;
  showImg = true;
  private _listFilter = '';

  public get listFilter(){
    return this._listFilter;
  }

  public set listFilter(value: string) {
    this._listFilter = value;
    this.agendamentoFilter = this.listFilter ? this.agendFilter(this.listFilter) : this.agendamento
  }

  agendFilter(filterBy: string): any {
    filterBy = filterBy.toLocaleLowerCase();
    return this.agendamento.filter(
      (agendamento: { exameName: string; medico: string }) =>
      agendamento.exameName.toLocaleLowerCase().indexOf(filterBy) !== -1 ||
      agendamento.medico.toLocaleLowerCase().indexOf(filterBy) !== -1
    );
  }

  constructor(private http: HttpClient){}


  ngOnInit(): void {
    this.getEventos();
  }

  alterImg(){
    this.showImg = !this.showImg;
  }

  public getEventos(): void {
    this.http.get('http://localhost:5069/api/fracasso').subscribe(
      response =>
      {this.agendamento = response;
      this.agendamentoFilter = this.agendamento },
    );

  }

  title = 'Yhiot-App';
}
