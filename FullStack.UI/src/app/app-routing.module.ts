import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeesListComponent } from './components/employees/employees-list/employees-list.component';
import { AddEmployeeComponent } from './components/employees/add-employee/add-employee.component';
import { EditEmployeeComponent } from './components/employees/edit-employee/edit-employee.component';
const routes: Routes = [
  //create a new object with path and component
  { 
    path: '', 
  component: EmployeesListComponent 
},
//create a new object with path and component
{
  path: 'employees',
  component: EmployeesListComponent
},
//create a new object with path of employees/add and component of AddEmployeeComponent
{
  path: 'employees/add',
  component: AddEmployeeComponent
},
//create a new object with path of employees/edit/:id and component of EditEmployeeComponent
{
  path: 'employees/edit/:id',
  component: EditEmployeeComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
