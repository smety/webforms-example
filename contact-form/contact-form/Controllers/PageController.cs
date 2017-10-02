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
            return View ();
        }

		public ActionResult About()
		{
			return View ();
		}
    }
}
