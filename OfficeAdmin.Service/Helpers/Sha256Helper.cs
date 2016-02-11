using System;
using System.Security.Cryptography;
using System.Text;

namespace OfficeAdmin.Service.Helpers
{
    public static class Sha256Helper
    {
        public static string GetHashBySha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}