using System.Collections.Generic;

namespace AccountManagers.Models
{
	public class Country
	{
		public int Id { get; set; }
		public string CountryName { get; set; }
		public virtual IEnumerable<Account> Accounts { get; set; } 
	}
}