import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Employee } from '../models/employee.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  //Create getAllEmployees() method that will make a GET request to the API to get all employees
   getAllEmployees(): Observable<Employee[]>{
        return this.http.get<Employee[]>(this.baseApiUrl + '/api/employees');
   }
  //Create addEmployee() method that will make a POST request to the API to add a new employee
  addEmployee(addEmployeeRequest: Employee): Observable<Employee>{
    addEmployeeRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<Employee>(this.baseApiUrl + '/api/employees', addEmployeeRequest);
  }
  //Create getEmployeeById() method that will make a GET request to the API to get an employee by id
  getEmployeeById(id: string): Observable<Employee>{
    return this.http.get<Employee>(this.baseApiUrl + '/api/employees/' + id);
  }
  //Create updateEmployee() method that will make a PUT request to the API to update an employee
  updateEmployee(id: string, updateEmployeeRequest: Employee): Observable<Employee>{
    return this.http.put<Employee>(this.baseApiUrl + '/api/employees/' + id, updateEmployeeRequest);
  }
  //Create deleteEmployee() method that will make a DELETE request to the API to delete an employee
  deleteEmployee(id: string): Observable<Employee>{
    return this.http.delete<Employee>(this.baseApiUrl + '/api/employees/' + id);
  }

}









