using System;
using System.Collections.Generic;
using System.Linq;
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
		    var usernameCookie = HttpContext.Request.Cookies.Get("username");
		    var passwordCookie = HttpContext.Request.Cookies.Get("password");


		    var username = usernameCookie.Value;
		    var password = passwordCookie.Value;

		    var hashedPassword = PasswordSecurityProvider.HashSha256(password);

		    var account = new Account
		    {
			    Username = username,
			    Password = hashedPassword,
			    Sex = viewModel.Sex ? Gender.Male : Gender.Female, 
				Country = _manager.GetCountryById(viewModel.SelectedCountryId),
				CountryId = viewModel.SelectedCountryId
		    };

		    var accountId = _manager.AddNewAccount(account);

		    var query = from acc in _manager.GetAllAccounts()
						where acc.Country.CountryName == account.Country.CountryName
						select acc;

		    var accountDisplayInfo = new List<AccountDisplayInfo>();

		    var i = 1;

		    foreach (var acc in query)
		    {
			    accountDisplayInfo.Add(new AccountDisplayInfo {AccountId = i, 
					CountryName = acc.Country.CountryName, 
					Username = acc.Username, 
					Gender = Enum.GetName(typeof(Gender), acc.Sex)});
			    i++;
		    }

		    return View("../FinalPage/DisplayFinalPage", new FinalPageViewModel {Accounts = accountDisplayInfo});
	    }
    }
}