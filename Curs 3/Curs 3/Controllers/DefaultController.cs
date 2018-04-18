using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace WebApplication1.Controllers
{
    public class CustomersController : ApiController
    {  //poarta de intrare in web service, o metoda care ret toata lista de clienti
        public List<Customer> GetCustomers()
        {
            using (CURS3Entities1 container = new CURS3Entities1())
            {
                return container.Customers.ToList();
            }
        }

    }
}
