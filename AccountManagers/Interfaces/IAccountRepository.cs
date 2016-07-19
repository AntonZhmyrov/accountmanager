using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountManagers.Models;

namespace AccountManagers.Interfaces
{
	public interface IAccountRepository
	{
		IEnumerable<Account> GetEntities();
		Account SelectById(int id);
		int Insert(Account account);
		void Delete(int accountId);
		void Update(Account accountToUpdate);
	}
}
