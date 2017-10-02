using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace contactform.Controllers
{


    public class PageController : Controller
    {

        public ActionResult Index()
        {
			ViewBag.Name = "Monjurul Habib";

            return View();
        }

        public ActionResult About()
        {
	
            //	ViewBag.Age = 56;

        //    ViewBag.MyMessageToUsers = "Hello from me.";
          //  ViewBag.AnswerText = "Your answer goes here.";

            return View();
        }
    }
}
