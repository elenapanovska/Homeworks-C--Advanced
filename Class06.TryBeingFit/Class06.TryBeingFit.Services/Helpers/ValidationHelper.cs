using System;
using System.Collections.Generic;
using System.Text;

namespace Class06.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumber(string number, int range)
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber)
            {
                return -1;
            }
            if(num <= 0 || num > range)
            {
                return -1;
            }
            return num;
        }

        public static string ValidateString(string str)
        {
            return str.Length < 2 ? null : str;
        }

        public static string ValidateUsername(string username)
        {
            return username.Length < 6 ? null : username;
        }

        public static string ValidatePassword(string password)
        {
            if(password.Length < 6)
            {
                return null;
            }

            //bool hasOneNumber = false;
            foreach(char character in password.ToCharArray())
            {
                if (char.IsNumber(character))
                {
                    //hasOneNumber = true;
                    //break;
                    return password;
                }
            }
            return null;
        }
    }
}
