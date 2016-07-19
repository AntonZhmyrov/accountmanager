using System.Data.Entity;

namespace AccountManagers.Models
{
	public class DataContext : DbContext
	{
		public DataContext()
            : base("DbConnection")
        { }

		public DbSet<Country> Countries { get; set; }
		public DbSet<Account> Accounts { get; set; } 
	}
}