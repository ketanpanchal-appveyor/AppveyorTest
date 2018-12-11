using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Learning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public class RegionPhone {

            public string Phone { get; set; }
            public string Email { get; set; }
        }


        public Task<ActionResult> GetRegionPhoneEmailById(int regionId) {

            //Make api call here
            //Generate new REgionPhone (model) and fill data in it and return it to ajax request in response
            return new RegionPhone() { Phone = "data from api Result", Email = "Email from api result"};

        }
    }
}
