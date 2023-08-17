using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudDemo.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using CrudDemo.Repository;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace CrudDemo.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

/*        [HttpGet("GetAllEmployees")]

        public List<Employees> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }*/

        // create get method to get all employees using task
        [HttpGet("GetAllEmployees")]
        public async Task<ActionResult<IEnumerable<Employees>>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }
        
    

        /*[HttpPost("SaveEmployee")]
        public ResponseModel SaveEmployee(Employees employeeModel)
        {
            return _employeeRepository.SaveEmployee(employeeModel);
        }*/

        // create post method to save employee using task
        [HttpPost("SaveEmployee")]
        public async Task<ActionResult<Employees>> SaveEmployee(Employees employeeModel)
        {
            return await _employeeRepository.SaveEmployee(employeeModel);
        }

        

        [HttpDelete("DeleteEmployee")]
        public ResponseModel DeleteEmployee(int employeeId)
        {
            return _employeeRepository.DeleteEmployee(employeeId);
        }


        // delete method to delete employee by id using task
        [HttpDelete("DeleteEmployeeById/{id}")]
        public async Task<ActionResult<Employees>> DeleteEmployeeById(int id)
        {
            return await _employeeRepository.DeleteEmployeeById(id);
        }

        [HttpGet("GetEmployeeById/{id}")]
        public Employees GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        // update employee using task
        [HttpPut("UpdateEmployee")]
        public async Task<ActionResult<Employees>> UpdateEmployee(Employees employeeModel)
        {
            return await _employeeRepository.UpdateEmployee(employeeModel);
        }   

        // update employee using id using task
        [HttpPut("UpdateEmployeeById/{id}")]
        public async Task<ActionResult<Employees>> UpdateEmployeeById(int id)
        {
            return await _employeeRepository.UpdateEmployeeById(id);
        }

        // update existing employee by id
        [HttpPut("UpdateEmployee/{id}")]
        public Employees UpdateEmployee(int id, Employees employeeModel)
        {
            return _employeeRepository.UpdateEmployee(id, employeeModel);

    }
}
}
