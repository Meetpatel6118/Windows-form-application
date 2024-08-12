using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MTPRAC_.VALIDATION
{
    public class validations
    {
        public static bool IsValidEmailFormat(string input)
        {
            if (!Regex.IsMatch(input, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidPassword(string input)
        {
            if (!Regex.IsMatch(input, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
            {

                return false;

            }

            return true;
        }
    }
}
