using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudDemo.Model;

namespace CrudDemo.Model
{
    public class EmployeeDBContext : DbContext

    {
        public EmployeeDBContext (DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
    }
}

