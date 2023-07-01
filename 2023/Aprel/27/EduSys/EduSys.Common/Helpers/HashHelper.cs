using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EduSys.Common.Helpers
{
    public static class HashHelper
    {
        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }

        public static string CreateSHA512(string value)
        {
            byte[] encryptedBytes;

            using (var hashTool = new SHA512Managed())
            {
                encryptedBytes = hashTool.ComputeHash(Encoding.UTF8.GetBytes(string.Concat(value)));
                hashTool.Clear();
            }

            return Convert.ToBase64String(encryptedBytes);
        }
    }
}
