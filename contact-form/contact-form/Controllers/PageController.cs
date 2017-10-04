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
			string CookieName = "MyCookieTest";  
            string CookieValue = "This is cookie value";
	  
            HttpCookie TestCookie = HttpContext.Request.Cookies[CookieName] ?? new HttpCookie(CookieName);
            TestCookie.Value = CookieValue;
			TestCookie.Expires = DateTime.Now.AddDays(365);
			HttpContext.Response.Cookies.Add(TestCookie);

            string cookieView = null;

			if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains(CookieName))
			{
				cookieView = this.ControllerContext.HttpContext.Request.Cookies[CookieName].Value;
            } 

            ViewData["testcookie"] = cookieView;

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
