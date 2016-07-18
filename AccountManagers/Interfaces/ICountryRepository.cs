using System.Collections.Generic;
using AccountManagers.Models;

namespace AccountManagers.Interfaces
{
	public interface ICountryRepository
	{
		IEnumerable<Country> GetEntities();
		Country SelectById(int id);
	}
}
