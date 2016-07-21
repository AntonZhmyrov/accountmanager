using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountManagers.Models
{
	public class AccountDisplayInfo
	{
		public int AccountId { get; set; }
		public string Username { get; set; }
		public string Gender { get; set; }
		public string CountryName { get; set; }
	}
}