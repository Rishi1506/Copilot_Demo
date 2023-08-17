import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmployeeDataComponent } from './employee-data/employee-data.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FormsModule, ReactiveFormsModule, FormGroup } from '@angular/forms';

// add material angular
// Path: src\app\app.module.ts
//


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
 import { MatToolbarModule } from '@angular/material/toolbar';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { EmployeeDataService } from 'Services/employeedata.service';
import { UpdateEmployeeComponent } from './update-employee/update-employee.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FooterComponent } from './footer/footer.component';

// import { MatIconModule } from '@angular/material/icon';
// import { MatButtonModule } from '@angular/material/button';
// import { MatCardModule } from '@angular/material/card';
// import { MatInputModule } from '@angular/material/input';
// import { MatFormFieldModule } from '@angular/material/form-field';

// @NgModule({
//   declarations: [
//     AppComponent,

//     EmployeeDataComponent,
//     NavbarComponent
//   ],
//   imports: [
//     BrowserModule,
//     AppRoutingModule,
//     BrowserAnimationsModule,
//     MatToolbarModule,
//     MatIconModule,
//     MatButtonModule,
//     MatCardModule,
//     MatInputModule,
//     MatFormFieldModule
//   ],
//   providers: [],
//   bootstrap: [AppComponent]
// })



@NgModule({
  declarations: [
    AppComponent,
    EmployeeDataComponent,
    NavbarComponent,
    UpdateEmployeeComponent,
    AddEmployeeComponent,
    DashboardComponent,
    FooterComponent
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    ReactiveFormsModule,
    FormsModule,
    
    
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { 
  
}

