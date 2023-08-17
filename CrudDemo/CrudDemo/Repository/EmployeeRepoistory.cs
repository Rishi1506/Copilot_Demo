using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudDemo.Model;
using CrudDemo.Repository;
// add directive for action result
using Microsoft.AspNetCore.Mvc;
// add employee model
using CrudDemo.Model;


namespace CrudDemo.Model
{
    public class EmployeeRespository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _context;

        public EmployeeRespository(EmployeeDBContext context)
        {
            _context = context;
        }

        public async Task<List<Employees>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        /*public List<Employees> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }*/

        public Employees GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        /*public ResponseModel SaveEmployee(Employees employeeModel)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                _context.Employees.Add(employeeModel);
                _context.SaveChanges();
                responseModel.IsSuccess = true;
                responseModel.Message = "Employee Saved Successfully";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }*/

        // implement save employee using task
        public async Task<ActionResult<Employees>> SaveEmployee(Employees employeeModel)
        {
            _context.Employees.Add(employeeModel);
            await _context.SaveChangesAsync();

            return employeeModel;
        }

        public ResponseModel DeleteEmployee(int employeeId)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var employee = _context.Employees.Find(employeeId);
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                responseModel.IsSuccess = true;
                responseModel.Message = "Employee Deleted Successfully";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }

        // delete method to delete employee by id using task
        public async Task<ActionResult<Employees>> DeleteEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return null;
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        /*public ResponseModel UpdateEmployee(Employees employeeModel)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                _context.Entry(employeeModel).State = EntityState.Modified;
                _context.SaveChanges();
                responseModel.IsSuccess = true;
                responseModel.Message = "Employee Updated Successfully";
            }
            catch (Exception ex)
            {
                responseModel.IsSuccess = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }*/

        // implement update employee using task

        public async Task<ActionResult<Employees>> UpdateEmployee(Employees employeeModel)
        {
            _context.Entry(employeeModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return employeeModel;
        }
  
        // implement update employee by id using task
        public async Task<ActionResult<Employees>> UpdateEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return null;
            }

            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return employee;
        }
        
    //    // update the existing employee data by id
    //     public ResponseModel UpdateEmployee(int employeeId)
    //     {
    //         ResponseModel responseModel = new ResponseModel();
    //         try
    //         {
    //             var employee = _context.Employees.Find(employeeId);
    //             _context.Employees.Update(employee);
    //             _context.SaveChanges();
    //             responseModel.IsSuccess = true;
    //             responseModel.Message = "Employee Updated Successfully";
    //         }
    //         catch (Exception ex)
    //         {
    //             responseModel.IsSuccess = false;
    //             responseModel.Message = ex.Message;
    //         }
    //         return responseModel;
    //     }

    //     // update the existing employee data by id
         public Employees UpdateEmployee(int id, Employees employeeModel)
         {
             var employee = _context.Employees.Find(id);
             if (employee == null)
             {
                 return null;
             }
             //employee.EmployeeId = employeeModel.EmployeeId;
             employee.EmployeeFirstName = employeeModel.EmployeeFirstName;
             employee.EmployeeLastName  = employeeModel.EmployeeLastName;
             employee.Salary = employeeModel.Salary;
             employee.Designation = employeeModel.Designation;
    //         employee.City = employeeModel.City;
    //         employee.State = employeeModel.State;
    //         employee.Zip = employeeModel.Zip;
    //         employee.Country = employeeModel.Country;

            _context.Employees.Update(employee);
             _context.SaveChanges();
    
             return employee;
        }
    //
              
    }
}