using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Curs4_CodeFirst_.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base("name=MyDbContext")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}