using System.Data.Entity;

namespace AccountManagers.Models
{
	public class AccountContext : DbContext
	{
		public AccountContext()
            : base("DbConnection")
        { }

		public DbSet<Account> Accounts { get; set; } 
	}
}