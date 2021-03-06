﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AccountManagers.Models;

namespace AccountManagers.Interfaces
{
	public interface IAccountManager
	{
		IEnumerable<Account> GetAllAccounts();
		IEnumerable<Country> GetCountriesFromDataBase();
		Country GetCountryById(int id);
		Account GetAccountById(int id);
		int AddNewAccount(Account account);
	}
}