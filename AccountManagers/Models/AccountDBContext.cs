using System.Data.Entity;

namespace AccountManagers.Models
{
	public class AccountDBContext : DbContext
	{
		public AccountDBContext()
			: base("AccountDBContext")
        { }

		public DbSet<Country> Countries { get; set; }
		public DbSet<Account> Accounts { get; set; } 
	}
}