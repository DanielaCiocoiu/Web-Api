using Curs4_CodeFirst_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Curs4_CodeFirst_.Controllers
{
    public class EmployeesController : ApiController
    {
        public HttpResponseMessage GetEmployees()
       
        {
            using (EmployeeDbContext context = new EmployeeDbContext())
          
            {
                var employees = context.Employees.ToList();

                if (employees == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Nu a fost gasit nicun anagajat!");

                return Request.CreateResponse(HttpStatusCode.OK, employees);
            }

        }
    }
}
