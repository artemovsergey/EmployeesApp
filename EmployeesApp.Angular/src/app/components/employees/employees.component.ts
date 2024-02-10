import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Employee } from '../../models/employee';
import { NgFor } from '@angular/common';
import { DatePipe } from '@angular/common';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-employees',
  standalone: true,
  imports: [NgFor, DatePipe, CurrencyPipe],
  templateUrl: './employees.component.html',
  styleUrl: './employees.component.scss'
})
export class EmployeesComponent {

  title: string = "Angular";
  employees?: Employee[] | null;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers() {
    this.http.get<Employee[]>('https://localhost:7236/api/Employees').subscribe({
      next: response => this.employees = response,
      error: error => console.log(error)
    })
  }



    
}
