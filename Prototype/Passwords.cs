using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Prototype
{
    class Passwords
    {
        public static string GetHash(string input)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(input);
            SHA256Managed hashCompute = new SHA256Managed();

            byte[] hash = hashCompute.ComputeHash(bytes);
            Debug.WriteLine("Computed hash: " + BitConverter.ToString(hash).Replace("-", "").ToLower());

            return BitConverter.ToString(hash).Replace("-", "").ToUpper();
        }

        public static bool Verify(string input, string hash)
        {
            return hash == GetHash(input);
        }
    }
}
