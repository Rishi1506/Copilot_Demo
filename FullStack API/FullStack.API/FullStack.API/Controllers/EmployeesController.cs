using FullStack.API.Data;
using FullStack.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Controllers
{
    //Add API Controller keyword to the class
    [ApiController]
    //Add Route attribute to the class
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        //Add a constructor and inject DbContext inside it and create a private field of type FullStackDbContext
        private readonly FullStackDbContext _context;
        public EmployeesController(FullStackDbContext context)
        {
            _context = context;
        }
        //Add a HttpGet method
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            //Call the ToList() method to get all the employees from the database
            var employees = await _context.Employees.ToListAsync();
            //Return the employees in the response
            return Ok(employees);   
        }
        // Add a HttpPost method
        [HttpPost]
        // Create a method of AddEmployee to add an employee to the database from the body
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            //Create a new Id fo type Guid of the employee
            employee.Id = Guid.NewGuid();
            //Add the employee to the database
            await _context.Employees.AddAsync(employee);
            //Save the changes to the database
            await _context.SaveChangesAsync();
            //Return the employee in the response
            return Ok(employee);
        }
        //Add a HttpGet method
        [HttpGet]
        //Add a route attribute with the id parameter
        [Route("{id:Guid}")]
        //Create a method of GetEmployeeById to get an employee from the database by id from the route
        public async Task<IActionResult> GetEmployeeById([FromRoute] Guid id)
        {
            //Get the employee from the database by id
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            if(employee == null)
            {
                //Return a 404 Not Found response if the employee is not found
                return NotFound();
            }
            //Return the employee in the response
            return Ok(employee);
        }
        // create a HttpPut method
        [HttpPut]
        //Add a route attribute with the id parameter
        [Route("{id:Guid}")]
        //Create a method of UpdateEmployee to update an employee in the database by id from the route
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employee updateEmployeeRequest)
        {
            //Get the employee from the database by id
            var employeeToUpdate = await _context.Employees.FindAsync(id);
            if(employeeToUpdate == null)
            {
                //Return a 404 Not Found response if the employee is not found
                return NotFound();
            }
            //Update the employee
            employeeToUpdate.Name = updateEmployeeRequest.Name;
            employeeToUpdate.Email = updateEmployeeRequest.Email;
            employeeToUpdate.Salary = updateEmployeeRequest.Salary;
            employeeToUpdate.Phone = updateEmployeeRequest.Phone;
            employeeToUpdate.Department = updateEmployeeRequest.Department;
            //Save the changes to the database
            await _context.SaveChangesAsync();
            //Return the employee in the response
            return Ok(employeeToUpdate);
        }
        // create a HttpDelete method
        [HttpDelete]
        //Add a route attribute with the id parameter
        [Route("{id:Guid}")]
        //Create a method of DeleteEmployee to delete an employee from the database by id from the route
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            //Get the employee from the database by id
            var employeeToDelete = await _context.Employees.FindAsync(id);
            if(employeeToDelete == null)
            {
                //Return a 404 Not Found response if the employee is not found
                return NotFound();
            }
            //Delete the employee
            _context.Employees.Remove(employeeToDelete);
            //Save the changes to the database
            await _context.SaveChangesAsync();
            //Return the employee in the response
            return Ok(employeeToDelete);
        }
       


    }
}
