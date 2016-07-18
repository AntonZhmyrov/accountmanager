using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagers.BusinessLogic;
using AccountManagers.Interfaces;
using AccountManagers.Models;
using AccountManagers.ViewModels;

namespace AccountManagers.Controllers
{
    public class HomeController : Controller
    {
	    private IAccountManager _manager;

	    public HomeController(IAccountManager manager)
	    {
		    _manager = manager;
	    }

	    // GET: Home
		[HttpGet]
        public ActionResult Index()
        {
	       return View();
        }

	    public ActionResult SecondPage()
	    {
			var countries = _manager.GetCountriesFromDataBase();
			return View(new SecondPageViewModel { Countries = countries });
	    }
    }
}