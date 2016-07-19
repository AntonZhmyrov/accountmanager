using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;

namespace AccountManagers.Utils
{
	public static class PasswordSecurityProvider
	{
		public static string EncryptPassword(string username, string password)
		{
			if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
			{
				throw new ArgumentNullException();
			}

			var byteData = Encoding.Default.GetBytes(password);
			return Encoding.Default.GetString(MachineKey.Protect(byteData, username));
		}

		public static string DecryptPassword(string passwordString, string username)
		{
			if (string.IsNullOrEmpty(passwordString) || string.IsNullOrEmpty(username))
			{
				throw new ArgumentNullException();
			}

			var byteData = Encoding.Default.GetBytes(passwordString);
			return Encoding.Default.GetString(MachineKey.Unprotect(byteData, username));
		}
	}
}