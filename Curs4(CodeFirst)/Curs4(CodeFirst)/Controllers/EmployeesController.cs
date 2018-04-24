using Curs4_CodeFirst_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace Curs4_CodeFirst_.Controllers
{
    public class EmployeesController : ApiController
    {
        [EnableQuery]
        public HttpResponseMessage GetEmployees()

        {

             IQueryable<Employee> employees = null;

            EmployeeDbContext context = new EmployeeDbContext();

            employees = context.Employees.AsQueryable();


            return Request.CreateResponse(HttpStatusCode.OK, employees);

            //using (EmployeeDbContext context = new EmployeeDbContext())
          
            //{
            //    var employees = context.Employees.ToList();

            //    if (employees == null)
            //        return Request.CreateResponse(HttpStatusCode.NotFound, "Nu a fost gasit nicun anagajat!");

            //    return Request.CreateResponse(HttpStatusCode.OK, employees);
            //}

        }
    }
}
