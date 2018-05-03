using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ClientServer
{
    public class WebApiCaller
    {
        public U Call<U>(string strUri, string strPath)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(strUri);
                var respTask = httpClient.GetAsync(strPath);
                respTask.Wait();
                var respons = respTask.Result;
                if (respons.IsSuccessStatusCode)
                {
                    var getTask = respons.Content.ReadAsAsync<U>();
                    getTask.Wait();
                    var result = getTask.Result;
                    return result;
                }
                return default(U);
            }
        }
        public X Call <X, Y>(string strUri, string strPath, Y content)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(strUri);
                httpClient.PostAsJsonAsync(strPath, content);
                respTask.Wait();
                var result = respTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var getTask = result.Content.ReadAsAsync<Y>();
                    getTask.Wait();
                    var res = getTask.Result;
                    return res;

                }
                return default (X)
            }
     }

}
