using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace contactform.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{
        [AllowAnonymous]
		public ActionResult Login()
		{
			return View();
		}

		[Authorize]
		public ActionResult Logout()
		{
			return View();
		}
	}
}
