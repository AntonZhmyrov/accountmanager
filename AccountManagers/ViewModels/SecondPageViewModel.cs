using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountManagers.Models;

namespace AccountManagers.ViewModels
{
	public class SecondPageViewModel
	{ 
		public Gender Sex { get; set; }

		public IEnumerable<Country> Countries { get; set; }

	}
}