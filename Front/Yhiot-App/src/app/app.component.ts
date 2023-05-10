import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{

  public agendamento: any;

  constructor(private http: HttpClient){}


  ngOnInit(): void {
    this.getEventos();
  }


  public getEventos(): void {
    this.http.get('http://localhost:5069/api/fracasso').subscribe(
      response => this.agendamento = response
    );

  }

  title = 'Yhiot-App';
}
