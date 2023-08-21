import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';
import { EmployeesService } from 'src/app/services/employees.service';

@Component({
  selector: 'app-employees-list',
  templateUrl: './employees-list.component.html',
  styleUrls: ['./employees-list.component.css']
})
export class EmployeesListComponent implements OnInit   {
  //create a list of employees property which can have of type Employee array
  employees: Employee[] = [];

  constructor(private employeesService: EmployeesService) { }
  ngOnInit(): void {
    //call the getAllEmployees() method from the EmployeesService to get all employees
    this.employeesService.getAllEmployees().subscribe({ 
      next: (employees) => {
      this.employees = employees;
    },  
    error: (response) => {
      console.log(response);
    } 
    } )   
  }
}
