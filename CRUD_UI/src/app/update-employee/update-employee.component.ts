import { Component, OnInit } from '@angular/core';
 import { EmployeeDataService } from 'Services/employeedata.service';
 import { HttpClient } from '@angular/common/http';
 import { Injectable } from '@angular/core';
  import { FormGroup, FormControl,ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
 import { ActivatedRoute } from '@angular/router';

 @Component({
   selector: 'app-update-employee',
   templateUrl: './update-employee.component.html',
   styleUrls: ['./update-employee.component.css']
 })
 export class UpdateEmployeeComponent implements OnInit {
   employee: any = {};
 employeeForm!: FormGroup;
employeeFirstName:string='';
employeeLastName:string='';
salary:string='';
designation:string='';

   constructor(private employeeDataService: EmployeeDataService, private route: ActivatedRoute) { }
  ngOnInit(): void {
    
    this.employeeDataService.getEmployeeById(this.route.snapshot.params['id']).subscribe((data: any) => {
      this.employee = data;
      console.log(this.employee);
    });
   }
   updateEmployee() {
    this.employeeDataService.updateEmployee(this.employee.id, this.employee).subscribe((data: any) => {
      console.log(data);
   });
  }
 }



