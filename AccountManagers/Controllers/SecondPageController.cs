using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagers.Interfaces;
using AccountManagers.ViewModels;

namespace AccountManagers.Controllers
{
    public class SecondPageController : Controller
    {
		private readonly IAccountManager _manager;

	    public SecondPageController(IAccountManager manager)
	    {
		    _manager = manager;
	    }

        public ActionResult SecondPage()
        {
			var countries = _manager.GetCountriesFromDataBase();
			return View(new SecondPageViewModel { Countries = countries });
        }

	    public ActionResult RedirectToHomePage()
	    {
			return RedirectToAction("Index", "Home");
	    }
    }
}