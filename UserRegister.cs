using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegister
    {
        public string regex_FirstName = "^[A-Z]{1}[a-z]{2,8}$";

        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, regex_FirstName);
        }
    }
}
