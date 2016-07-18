using System.Collections.Generic;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.DataAccess
{
	public class CountryRepository : ICountryRepository
	{
		private readonly CountryContext _dataContext;

		public CountryRepository()
		{
			_dataContext = new CountryContext();
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