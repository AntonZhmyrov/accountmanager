using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Security;
using System.Security.Cryptography;

namespace AccountManagers.Utils
{
	public static class PasswordSecurityProvider
	{
		public static string HashSha256(string password)
		{
			var sha256Provider = new SHA256Cng();
			var passwordBytes = Encoding.Default.GetBytes(password);

			return Encoding.UTF8.GetString(sha256Provider.ComputeHash(passwordBytes));
		}
	}
}