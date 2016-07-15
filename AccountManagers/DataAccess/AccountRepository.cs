using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.DataAccess
{
	public class AccountRepository : IRepository<Account>
	{
		public IEnumerable<Account> GetEntities()
		{
			throw new NotImplementedException();
		}

		public Account SelectById(int id)
		{
			throw new NotImplementedException();
		}

		public void Insert(Account obj)
		{
			throw new NotImplementedException();
		}
	}
}