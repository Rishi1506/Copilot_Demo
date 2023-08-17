using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Model
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; } 
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public int Salary { get; set; }

        public string Designation { get; set; }


            

    }
}
