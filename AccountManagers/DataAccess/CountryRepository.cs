using System.Collections.Generic;
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
			return _dataContext.Countries.Find(id);
		}
	}
}