import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit{
  constructor(private http: HttpClient){}

  ngOnInit(): void {
    this.getUsers();
  }

  public users: any;

  public getUsers(): void{
    this.http.get('http://localhost:5069/api/user').subscribe(
      response => this.users = response
    );
  }

}
