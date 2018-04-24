namespace Curs4_CodeFirst_.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Curs4_CodeFirst_.Models.EmployeeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Curs4_CodeFirst_.Models.EmployeeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Employees.AddOrUpdate(w => w.Id,
                   new Employee { Id = 1, FirstName = "Nume 1", LastName = "lastName 1" },
                   new Employee { Id = 2, FirstName = "Nume 2", LastName = "lastName 2" },
                   new Employee { Id = 3, FirstName = "Nume 3", LastName = "lastName 3" }
               );
        }
    }
}
