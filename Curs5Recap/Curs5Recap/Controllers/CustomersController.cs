using Curs5Recap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Curs5Recap.Controllers
{
    public class CustomersController : ApiController
    {
        CURS3_DanaEntities context;
        public CustomersController()
        {
            context = new CURS3_DanaEntities();
        }
        [HttpGet]
        public IList<Customer> GetCustomers()
        {

            return context.Customers.ToList();
        }
        [HttpPost]
        public Customer AddCustomer([FromBody] Customer customer)
        {

            context.Customers.Add(customer);
            context.SaveChanges();

            var result = context.Customers.FirstOrDefault(w => w.Id == customer.Id);
            return result;
        }
    }
}