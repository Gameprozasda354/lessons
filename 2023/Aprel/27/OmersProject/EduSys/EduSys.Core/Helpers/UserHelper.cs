using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Core.Helpers
{
	public static class UserHelper
	{
		public static string HashPassword(string password)
		{
			var sha512Password = HashHelper.SHA512Hash(password);

			return sha512Password;
		}

		
	}
}
