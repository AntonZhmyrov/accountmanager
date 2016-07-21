using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.DataAccess
{
	public class AccountRepository : IAccountRepository
	{
		private readonly AccountDBContext _dataContext;

		public AccountRepository()
		{
			_dataContext = new AccountDBContext();
		}

		public IEnumerable<Account> GetEntities()
		{
			return _dataContext.Accounts;
		}

		public Account SelectById(int id)
		{
			return _dataContext.Accounts.Find(id);
		}

		public int Insert(Account account)
		{
			_dataContext.Accounts.Add(account); 
			_dataContext.SaveChanges();

			return _dataContext.Entry(account).Entity.Id;
		}

		public void Delete(int accountId)
		{
			_dataContext.Accounts.Remove(_dataContext.Accounts.Find(accountId)); 
			_dataContext.SaveChanges();
		}

		public void Update(Account accountToUpdate)
		{
			_dataContext.Accounts.Attach(accountToUpdate);
			_dataContext.Entry(accountToUpdate).State = EntityState.Modified;
			_dataContext.SaveChanges();
		}
	}
}