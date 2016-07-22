using System.Collections.Generic;
using System.Linq;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.DataAccess
{
	public class CountryRepository : ICountryRepository
	{
		private readonly AccountDBContext _dataContext;

		public CountryRepository()
		{
			_dataContext = new AccountDBContext();
		}

		public IEnumerable<Country> GetEntities()
		{
			return _dataContext.Countries;
		}

		public Country SelectById(int id)
		{
			return _dataContext.Countries.Single(m => m.Id == id);
		}
	}
}