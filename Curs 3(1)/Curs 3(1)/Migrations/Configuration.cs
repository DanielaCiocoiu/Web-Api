namespace Curs_3_1_.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Curs_3_1_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.Curs_3_1_Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Customers.AddOrUpdate(a => a.Id,
    new Customer { Id = "1", CompanyName = "comp 1", ContactName = "contact 1", City = "City1", OrderId = 101 },
    new Customer { Id = "2", CompanyName = "comp 1", ContactName = "contact 1", City = "City1", OrderId = 101 },
    new Customer { Id = "3", CompanyName = "comp 1", ContactName = "contact 1", City = "City1", OrderId = 102 },
    new Customer { Id = "4", CompanyName = "comp 1", ContactName = "contact 1", City = "City1", OrderId = 103 }
    );

            context.Orders.AddOrUpdate(w => w.Id,
                    new Order() { Id = 101, Nume = "comanda 1 " },
                    new Order() { Id = 102, Nume = "comanda 2" }
                );
        }

    }
}

