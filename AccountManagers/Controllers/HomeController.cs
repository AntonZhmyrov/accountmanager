using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagers.Models;

namespace AccountManagers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
	        using (var cc = new CountryContext())
	        {
		        cc.Countries.Add(new Country {CountryName = "Ukraine"});

		        cc.SaveChanges();

		        var countries = cc.Countries;

		        return countries.First().CountryName;
	        }

        }
    }
}