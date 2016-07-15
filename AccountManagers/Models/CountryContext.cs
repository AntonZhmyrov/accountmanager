using System.Data.Entity;

namespace AccountManagers.Models
{
	public class CountryContext : DbContext
	{
		public CountryContext()
            : base("DbConnection")
        { }

		public DbSet<Country> Countries { get; set; } 
	}
}