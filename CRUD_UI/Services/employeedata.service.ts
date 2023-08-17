import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
/*export class EmployeedataService {

  constructor() { }
}*/

// create a service to get the data from the server
// Path: src\app\employee-data\employee-data.service.ts
export class EmployeeDataService {
  constructor(private http: HttpClient) { }
  getEmployees() {
    return this.http.get<any>('https://localhost:7261/GetAllEmployees'); 
  }

  // get employee by id
  getEmployeeById(id: number) {
    return this.http.get<any>('https://localhost:7261/GetEmployeeById/' + id);
  }

  // create a service to delete the data from the server
  // Path: src\app\employee-data\employee-data.service.ts
  deleteEmployee(id: number) {
    return this.http.delete<any>('https://localhost:7261/DeleteEmployeeById/' + id);
  }


  updateEmployee(id: number, employee: any) {
    return this.http.put<any>('https://localhost:7261/UpdateEmployee/' + id, employee);
  }

  // create a service to add the data from the server
  // Path: src\app\add-employee\add-employee.service.ts
  addEmployee(employee: any) {
    return this.http.post<any>('https://localhost:7261/SaveEmployee', employee);
  }

}
