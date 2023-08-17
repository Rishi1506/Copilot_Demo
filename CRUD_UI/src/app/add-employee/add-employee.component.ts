import { Component } from '@angular/core';
//import { EmployeeDataService } from './add-employee.service';
import { EmployeeDataService } from 'Services/employeedata.service';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormGroup, FormControl,ReactiveFormsModule, FormsModule} from '@angular/forms';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
/*export class AddEmployeeComponent {

}*/

// use add method in the component
// Path: src\app\add-employee\add-employee.component.ts
// import { Component } from '@angular/core';

//
// @Component({
//   selector: 'app-add-employee',

//   templateUrl: './add-employee.component.html',
//   styleUrls: ['./add-employee.component.css']
// })
 /*export class AddEmployeeComponent {
  
  employeeFirstName:string='';
  employeeLastName:string='';
  salary:string='';
  designation:string='';
  //employee: any = {};
  employeeForm!: FormGroup;
  constructor(private employeeDataService: EmployeeDataService) { }

  ngOnInit() {
    this.employeeForm = new FormGroup({
      employeeFirstName: new FormControl(''),
      employeeLastName: new FormControl(''),
      salary: new FormControl(''),
      designation: new FormControl(''),
      
    });
  }
  addEmployee() {
    this.employeeDataService.addEmployee(this.employeeForm.value).subscribe((data: any) => {
       console.log(data);
       console.log(data);
     });
     
   }
 }*/


 // create a form group in the component
// Path: src\app\add-employee\add-employee.component.ts
// import { Component } from '@angular/core';
// import { EmployeeDataService } from 'Services/employeedata.service';
// import { HttpClient } from '@angular/common/http';
// import { Injectable } from '@angular/core';
// import { FormGroup, FormControl,ReactiveFormsModule } from '@angular/forms';
// import { FormsModule } from '@angular/forms';
//
// @Component({
//   selector: 'app-add-employee',
//   templateUrl: './add-employee.component.html',
//   styleUrls: ['./add-employee.component.css']
// })
export class AddEmployeeComponent {
   employee: any = {};
   employeeForm!: FormGroup;
  constructor(private employeeDataService: EmployeeDataService) { }
   ngOnInit() {
     this.employeeForm = new FormGroup({
       employeeFirstName: new FormControl(''),
       employeeLastName: new FormControl(''),
       salary: new FormControl(''),
      designation: new FormControl(''),

    });
   }
   addEmployee() {
     this.employeeDataService.addEmployee(this.employeeForm.value).subscribe((data: any) => {
       console.log(data);
      //Swal.fire("Record saved successfuly", "success");
      Swal.fire({
        icon: 'success',
        title: 'Record saved successfuly',
        showConfirmButton: true,
      })
     });
     return this.employeeForm.reset();
   }
 }




 
