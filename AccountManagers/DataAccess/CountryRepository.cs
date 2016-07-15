using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.DataAccess
{
	public class CountryRepository : IRepository<Country>
	{
		public IEnumerable<Country> GetEntities()
		{
			throw new NotImplementedException();
		}

		public Country SelectById(int id)
		{
			throw new NotImplementedException();
		}

		public void Insert(Country obj)
		{
			throw new NotImplementedException();
		}
	}
}