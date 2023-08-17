import { Component, OnInit } from '@angular/core';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { EmployeeDataService } from 'Services/employeedata.service';
import Swal from 'sweetalert2';
//import { NgxPaginationModule } from 'ngx-pagination'; // <-- import the module

@Component({
  selector: 'app-employee-data',
  templateUrl: './employee-data.component.html',
  styleUrls: ['./employee-data.component.css']
})
//export class EmployeeDataComponent {
//employees: any;

export class EmployeeDataComponent implements OnInit {
[x: string]: any;
  employees: any[]=[];
   constructor(private employeeDataService: EmployeeDataService) { }
   ngOnInit(){
     this.employeeDataService.getEmployees().subscribe((data: any) => {
       this.employees = data;
       console.log(this.employees);
     });

  }
  deleteEmployee(id: number) {
    Swal.fire({
      title: 'Are you sure?',
      text: 'You will not be able to recover this record!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, delete it!',
      cancelButtonText: 'No, keep it'

    }).then((result) => {
      if (result.value) {
        this.employeeDataService.deleteEmployee(id).subscribe((data: any) => {
          console.log(data);
          this.employeeDataService.getEmployees().subscribe((data: any) => {
            this.employees = data;
            console.log(this.employees);
          });
        });    
        Swal.fire(
          'Deleted!',
          'Your record has been deleted.',
          'success'
        )
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire(
          'Cancelled',
          'Your record is safe :)',
          'error'
        )
      }
    }
    )
   

    
}


}





