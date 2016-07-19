using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace AccountManagers.ViewModels
{
	public class HomePageViewModel
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string ConfirmedPassword { get; set; }
	}
}