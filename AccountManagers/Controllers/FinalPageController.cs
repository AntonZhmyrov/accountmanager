﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountManagers.ViewModels;

namespace AccountManagers.Controllers
{
    public class FinalPageController : Controller
    {
        // GET: FinalPage
        public ActionResult DisplayFinalPage()
        {
            return View();
        }
    }
}