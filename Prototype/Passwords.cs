using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;

namespace Prototype
{
    class Passwords
    {
        public static string GetHash(string input)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            SHA256Managed hashCompute = new SHA256Managed();

            byte[] hash = hashCompute.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public static bool Verify(string input, string hash)
        {
            return hash == GetHash(input);
        }
    }
}
