using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
			var httpCookie = HttpContext.Request.Cookies.Get("username");

			if (httpCookie != null)
			{
				var username = httpCookie.Value;

				if (HttpContext.Request.Cookies["username"] != null &&
				    HttpContext.Request.Cookies["password"] != null)
				{
					var usernameCookie = new HttpCookie("username");
					var passwordCookie = new HttpCookie("password");

					usernameCookie.Expires = DateTime.Now.AddDays(-1d);
					passwordCookie.Expires = DateTime.Now.AddDays(-1d);

					HttpContext.Response.Cookies.Add(usernameCookie);
					HttpContext.Response.Cookies.Add(passwordCookie);
				}

				return View(new HomePageViewModel {Username = username});
			}

			return View();
		}

	    [HttpPost]
	    public ActionResult SaveCookies(HomePageViewModel viewModel)
		{
			if (viewModel != null)
			{
				HttpContext.Response.Cookies.Add(new HttpCookie("username", viewModel.Username));

				HttpContext.Response.Cookies.Add(new HttpCookie("password", 
					PasswordSecurityProvider.EncryptPassword(viewModel.Username,viewModel.Password)));
			}

			return RedirectToAction("SecondPage", "SecondPage");
		}
    }
}