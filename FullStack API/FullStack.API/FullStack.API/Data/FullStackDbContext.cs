using FullStack.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FullStack.API.Data
{
    public class FullStackDbContext : DbContext
    {
        //create a constructor with the DbContextOptions parameter and pass it to the base class
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options) : base(options)
        {

        }
        //create a DbSet property of type Employee
        public DbSet<Employee> Employees { get; set; }

    }
}
