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

  currentSort: string = '';
  sortDirection: boolean = false; // false для сортировки по возрастанию, true для сортировки по убыванию

  sort(column: string): void {
    if (this.currentSort === column) {
      this.sortDirection = !this.sortDirection;
    } else {
      this.currentSort = column;
      this.sortDirection = false;
    }
  }


  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getUsers();
  }

  getUsers() {
    this.http.get<Employee[]>('http://localhost:5231/api/Employees').subscribe({
      next: response => this.employees = response,
      error: error => console.log(error)
    })
  }



    
}
