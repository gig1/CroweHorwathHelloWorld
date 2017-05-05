using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace CroweHorwathHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.MessageFromApi = "";
            return View();
        }

        public ActionResult connectToApi()
        {
            try
            {
                string baseAddress = "http://localhost:9000/api/value";

                HttpClient client = new HttpClient();

                string response = client.GetStringAsync(baseAddress).Result;
                ViewBag.MessageFromApi = response;
            }
            catch (Exception ex)
            {
                string response = "Oops! Something went wrong... Error connecting to the API";
                ViewBag.MessageFromApi = response;
            }
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}