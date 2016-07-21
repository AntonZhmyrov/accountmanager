using System;
using System.Collections.Generic;
using System.Linq;
using AccountManagers.Interfaces;
using AccountManagers.Models;

namespace AccountManagers.BusinessLogic
{
	public class AccountManager : IAccountManager
	{
		private readonly ICountryRepository _countryRepository;
		private readonly IAccountRepository _accountRepository;

		public AccountManager(ICountryRepository countryRepository, IAccountRepository accountRepository)
		{
			_countryRepository = countryRepository;
			_accountRepository = accountRepository; 
		}

		public IEnumerable<Account> GetAllAccounts()
		{
			return _accountRepository.GetEntities();
		}

		public IEnumerable<Country> GetCountriesFromDataBase()
		{
			return _countryRepository.GetEntities();
		}

		public Country GetCountryById(int id)
		{
			return _countryRepository.SelectById(id);
		}

		public Account GetAccountById(int id)
		{
			return _accountRepository.SelectById(id);
		}

		public int AddNewAccount(Account account)
		{
			return _accountRepository.Insert(account);
		}
	}
}