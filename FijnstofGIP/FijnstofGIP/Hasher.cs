using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FijnstofGIP
{
    class Hasher
    {
        public static string Hash_SHA1(string input)
        {
            //SHA1 hash, hashed de ingevoerde data
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                //maakt de hash code
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                //lengte van de input *4
                var sb = new StringBuilder(hash.Length * 4);

                //neemt elke byte in de hash
                foreach (byte b in hash)
                {
                    //voegt de hash bytes samen om de lengte van *4 te bereiken
                    sb.Append(b.ToString("X4"));
                }
                //returned de de string
                return sb.ToString();
            }
        }
    }
}
