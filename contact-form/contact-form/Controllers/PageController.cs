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
			string CookieName   = "MyCookieTest";  
            string CookieValue  = "This is cookie value";
	  
            HttpCookie TestCookie = HttpContext.Request.Cookies[CookieName] ?? new HttpCookie(CookieName);
            TestCookie.Value = CookieValue;
			TestCookie.Expires = DateTime.Now.AddDays(365);
			HttpContext.Response.Cookies.Add(TestCookie);

            string cookieView = null;

			if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains(CookieName)) // If cookie exist in current context
			{
				cookieView = this.ControllerContext.HttpContext.Request.Cookies[CookieName].Value;
            } 

            ViewData["testcookie"] = cookieView;

			return View();
        }

        public ActionResult About()                    
        {

            string SessionName      = "MySessionTest";
            string SessionValue     = "This is session value";

            Session[SessionName]    = SessionValue;

			ViewData["name"]        = "Tomas Smetka";
            ViewData["age"]         = 28;
			ViewData["email"]       = "tomas@smetka.net";

            ViewData["testsession"] = Session[SessionName];

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
