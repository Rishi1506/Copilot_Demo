namespace FullStack.API.Models
{
    public class Employee
    {
        //create properties for the employee class with Id of type Guid, Name, Email, Phone of type long, Salary of type long and Department
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }


    }
}
