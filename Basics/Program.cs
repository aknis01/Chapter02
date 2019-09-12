using System;
using System.Security.Cryptography;
using System.Text;

namespace Basics
{
    /// <summary>
    /// Приложение
    /// </summary>
    class Program
    {
        public static string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        public static string GetAuthHeader(string login, string password)
        {

            return $"{Convert.ToBase64String(Encoding.UTF8.GetBytes(login))} {Convert.ToBase64String(Encoding.UTF8.GetBytes(password))}";
        }

        static void Main(string[] args)
        {
            var auth = GetAuthHeader("12644721-88bf-49d2-8617-16e43b7d41fc", "2mo6alGmx7QKhj24");
            var hash = GetHash("2mo6alGmx7QKhj24");
            Console.WriteLine(hash);
        }
    }
}
