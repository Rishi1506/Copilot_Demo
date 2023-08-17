using CrudDemo.Model;
// add directive for action result
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CrudDemo.Repository
{
    public interface IEmployeeRepository
    {
        // list of all emplyooes
        // create get method to get all employees using task
        Task<List<Employees>> GetAllEmployees();
        //List<Employees> GetAllEmployees();

        // delete method to delete employee by id using task
        Task<ActionResult<Employees>> DeleteEmployeeById(int id);
    

        // get employee details by employee id
        //  
        Employees GetEmployeeById(int id);

        


        //save employee
        //ResponseModel SaveEmployee(Employees employeeModel);

        // save employee using task
        Task<ActionResult<Employees>> SaveEmployee(Employees employeeModel);

        // update employee using task
        Task<ActionResult<Employees>> UpdateEmployee(Employees employeeModel);

        // update employee by id using task
        Task<ActionResult<Employees>> UpdateEmployeeById(int id);

        // update existing employee by id
        Employees UpdateEmployee(int id, Employees employeeModel);
       

        
        
        /// delete employee
        /// <param name="employeeId"></param>

        ResponseModel DeleteEmployee(int employeeId);
    }


    }
