using ClientServer.Models;
using ClientServer.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ClientServer.Controllers
{
    public class ClientiController : ApiController//cate cath-uri am? cate se apeleaza? unul singur, se intra prin finally, 
    {
        string strUri;
        WebApiCaller caller;

        public ClientiController()
        {
            strUri = $"http//localhost:52244/api/";
            caller = new WebApiCaller();
        }
        [HttpGet]
        public HttpResponseMessage GetClienti()
        {
            try
            {
                var result = caller.Call<List<Customer>>(strUri, "customer");
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }

            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Contactati admin ")
            }

        }
        [HttpGet]
        public HttpResponseMessage GetClient(string id)
        {
            try
            {
                var client = caller.Call<Customer>(strUri, "customers?id=YYY");
                if (client == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Clientul nu a fost gasit")
                //throw new HttpResponseException(HttpStatusCode.NotFound);
            return Request.CreateResponse(HttpStatusCode.OK, client);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorRespons(HttpStatusCode.InternalServerError, "Contactati ")
            }
        }
        [HttpPost]
        [CustomValidators]
        public HttpResponseMessage AddClient([FromBody] Customer client)

        {
            try//model state
           
            {
                if (!ModelState.IsValid)
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                var clientRes = caller.Call<Customer, Customer>(strUri, "customers", client);
                return Request.CreateResponse(HttpStatusCode.OK, clientRes);
            }
            cath(Exception ex)
                {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}