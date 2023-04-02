using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LanguageChanger
{
    internal class Strings
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string plainText)
        {
            var base64EncodedBytes = Convert.FromBase64String(plainText);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
