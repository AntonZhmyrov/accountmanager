using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountManagers.Models;

namespace AccountManagers.ViewModels
{
	public class FinalPageViewModel
	{
		public IEnumerable<AccountDisplayInfo> Accounts { get; set; } 
	}
}