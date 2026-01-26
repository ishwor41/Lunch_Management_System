using System;
using System.Security.Cryptography;
using System.Text;

namespace LunchManagementSystem.Helpers
{
    public static class PasswordHelper
    {
        public static byte[] HashPassword(string password, Guid salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                string combined = password + salt.ToString();
                return sha.ComputeHash(Encoding.UTF8.GetBytes(combined));
            }
        }
    }
}
