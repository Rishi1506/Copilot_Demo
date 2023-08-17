import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EmployeeDataComponent } from './employee-data/employee-data.component';
import { FooterComponent } from './footer/footer.component';
import { UpdateEmployeeComponent } from './update-employee/update-employee.component';

const routes: Routes = [
 
  { 
    path: '', 
    component: EmployeeDataComponent 
  },
  {
    path : 'add-employee',
    component : AddEmployeeComponent
  },
  {
    path : 'update-employee',
    component : UpdateEmployeeComponent
  },
  {
    path : 'dashboard',
    component : DashboardComponent
  },
  {
    path : 'footer',
    component : FooterComponent
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }

// add path to the employee-data component
// Path: src\app\app-routing.module.ts
// 




