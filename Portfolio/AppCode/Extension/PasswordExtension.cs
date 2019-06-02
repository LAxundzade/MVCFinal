using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Portfolio
{
    public static partial class Extension
    {
        public static string getHashPassword(string password)
        {
            byte[] bytearray = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] HashedArray = new SHA256Managed().ComputeHash(bytearray);
            string hashedPassword = ASCIIEncoding.ASCII.GetString(HashedArray);
            return hashedPassword;
        }

        public static bool checkPassword(string hashedpassword, string password)
        {
            return hashedpassword == getHashPassword(password);
        }

    }
}