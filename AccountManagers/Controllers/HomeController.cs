using System;
using System.Web;
using System.Web.Mvc;
using AccountManagers.BusinessLogic;
using AccountManagers.Interfaces;
using AccountManagers.Models;
using AccountManagers.ViewModels;
using AccountManagers.Utils;

namespace AccountManagers.Controllers
{
    public class HomeController : Controller
    {
		[HttpGet]
        public ActionResult Index()
		{
			//HttpContext.Request.Cookies.Clear();
			//HttpContext.Response.Cookies.Clear();

			//if (CookieManager.CookieExists("loggedinuser", HttpContext))
			//{
			//	return RedirectToAction("DisplayFinalPage", "FinalPage");	
			//}
			
			CookieManager.RemoveCookie("loggedinuser", HttpContext);

			var uName = "";
			var pass = "";

			var statusUsername = CookieManager.RemoveCookie("username", HttpContext, out uName);
			var statusPassword = CookieManager.RemoveCookie("password", HttpContext, out pass);

			if (!statusUsername)
			{
				return View(new HomePageViewModel { Username = uName });
			}

			return View();
		}

	    [HttpPost]
	    public ActionResult SaveCookies(HomePageViewModel viewModel)
		{
			if (viewModel != null) 
			{
				CookieManager.AddCookie("username", viewModel.Username, HttpContext);
				CookieManager.AddCookie("password", viewModel.Password, HttpContext);
			}

			return RedirectToAction("SecondPage", "SecondPage");
		}
    }
}