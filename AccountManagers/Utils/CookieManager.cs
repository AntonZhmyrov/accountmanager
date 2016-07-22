using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountManagers.Utils
{
	public static class CookieManager
	{
		public static void AddCookie(string cookieName, string cookieValue, HttpContextBase httpContext)
		{
			var httpCookie = new HttpCookie(cookieName, cookieValue); 
			httpContext.Response.Cookies.Add(httpCookie);
		}

		public static bool RemoveCookie(string cookieName, HttpContextBase httpContext, out string cookieValue)
		{
			var status = false;
			cookieValue = "";

			var httpCookie = httpContext.Request.Cookies.Get(cookieName); 

			if (httpCookie != null)
			{
				var val = httpCookie.Value;

				var newCookie = new HttpCookie(cookieName) {Expires = DateTime.Now.AddDays(-1d)};

				httpContext.Response.Cookies.Add(newCookie);

				status = true;

				cookieValue = val;
			}

			return status;
		}

		public static void RemoveCookie(string cookieName, HttpContextBase httpContext)
		{
			var httpCookie = httpContext.Request.Cookies.Get(cookieName);

			if (httpCookie != null)
			{
				var newCookie = new HttpCookie(cookieName) { Expires = DateTime.Now.AddDays(-1d) };

				httpContext.Response.Cookies.Add(newCookie);
			}

		}

		public static string ReadCookieValue(string cookieName, HttpContextBase httpContext)
		{
			var cookieValue = "";

			var cookie = httpContext.Request.Cookies.Get(cookieName);

			if (cookie != null)
			{
				cookieValue = cookie.Value;
			}

			return cookieValue;
		}

		public static bool CookieExists(string cookieName, HttpContextBase httpContext)
		{
			var cookie = httpContext.Request.Cookies.Get(cookieName);
			return cookie == null;
		}
	}
}