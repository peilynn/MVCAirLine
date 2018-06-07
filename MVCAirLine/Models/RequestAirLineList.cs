using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace MVCAirLine.Models
{
    public static class RequestAirLineList
    {
        public static async Task <RootObject> SearchAsync(string Querystring)
        {
            string Address = "http://124.9.7.222/ggogobfm/Skyscanner/Search?request=";
            Address = Address + Querystring;
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(Address);
            response.EnsureSuccessStatusCode();
            string pageXML = await response.Content.ReadAsStringAsync();
            string pageJson = JsonConvert.SerializeObject(pageXML);

            RootObject lists = JsonConvert.DeserializeObject<RootObject>(pageXML);

            return lists;
        }

    }
}