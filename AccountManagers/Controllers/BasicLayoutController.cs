using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagers.ViewModels;

namespace AccountManagers.Controllers
{
    public class BasicLayoutController : Controller
    {
        // GET: BasicLayout
        public PartialViewResult ActionLinkRouting()
        {
	        var cookie = HttpContext.Request.Cookies.Get("loggedinuser");

	        var enabled = false;
	        var actionLinkName = "";

	        if (cookie != null)
	        {
		        actionLinkName = string.Concat(cookie.Value, "  Log out");
		        enabled = true;
	        }
	        else
	        {
		        actionLinkName = "Log in";
	        }

			return PartialView(new BasicLayoutViewModel { ActionLinkName = actionLinkName, Enabled = enabled });
	        
        }
    }
}