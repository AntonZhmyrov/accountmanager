using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagers.Interfaces;
using AccountManagers.Models;
using AccountManagers.Utils;
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
			if (CookieManager.CookieExists("loggedinuser", HttpContext))
			{
				return RedirectToAction("DisplayFinalPage", "FinalPage");
			}

			var countries = _manager.GetCountriesFromDataBase();
			return View(new SecondPageViewModel { Countries = countries });
        }

	    public ActionResult RedirectToHomePage()
	    {
			return RedirectToAction("Index", "Home");
	    }

	    [HttpPost]
	    public ActionResult SecondPage(SecondPageViewModel viewModel)
	    {
		    var username = CookieManager.ReadCookieValue("username", HttpContext);
		    var password = CookieManager.ReadCookieValue("password", HttpContext);

		    var hashedPassword = PasswordSecurityProvider.HashSha256(password);

		    var account = new Account
		    {
			    Username = username,
			    Password = hashedPassword,
			    Sex = viewModel.Sex ? Gender.Male : Gender.Female,
				CountryId = viewModel.SelectedCountryId
		    };

		    _manager.AddNewAccount(account);

		    var query = from acc in _manager.GetAllAccounts()
						where acc.CountryId == account.CountryId
						select acc;

		    var accountDisplayInfo = query.Select(acc => new AccountDisplayInfo
		    {
			    CountryName = _manager.GetCountryById(acc.CountryId).CountryName,
			    Username = acc.Username,
			    Gender = Enum.GetName(typeof (Gender), acc.Sex)
		    }).ToList();

		    var uName = "";
		    var pass = "";

			CookieManager.RemoveCookie("username", HttpContext, out uName);
			CookieManager.RemoveCookie("password", HttpContext, out pass);

			CookieManager.AddCookie("loggedinuser", account.Username, HttpContext);

		    return View("../FinalPage/DisplayFinalPage", new FinalPageViewModel {Accounts = accountDisplayInfo});
	    }
    }
}