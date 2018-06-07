using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using MVCAirLine.Models;

namespace MVCAirLine.Controllers
{
    public class AirLineController : Controller
    {
        // GET: AirLine
        public ActionResult Index()
        {
            return View();
        }

     
         public async System.Threading.Tasks.Task<ActionResult> RequestAirLineDetailAsync() 
        {
            //string querystring = Request.Url.PathAndQuery;
            //string[] querystrings = querystring.Split('=');
            //RootObject trips = await RequestAirLineList.SearchAsync(querystrings[1]);
            ////string message = await RequestAirLineList.SearchAsync(querystrings[1]);

            //////ViewBag.text = message;

            return View(/*trips*/);
        }

    }
}