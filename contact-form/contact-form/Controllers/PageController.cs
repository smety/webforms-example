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
			return View();
        }

        public ActionResult About()
        {
			ViewData["name"]        = "Tomas Smetka";
            ViewData["age"]         = 28;
			ViewData["email"]       = "tomas@smetka.net";

            return View();
        }

		public ActionResult Services()
		{
            string[] Technology = new string[] { "C#", "PHP", "JS", "CSS"};
			ViewData["data"] = Technology;
			return View(Technology);
		}
    }
}
