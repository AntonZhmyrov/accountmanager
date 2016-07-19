using System.Collections.Generic;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.DataAccess
{
	public class CountryRepository : ICountryRepository
	{
		private readonly DataContext _dataContext;

		public CountryRepository()
		{
			_dataContext = new DataContext();
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