using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class FirstNameException : Exception
    {
        public FirstNameException(string messege) : base(messege)
        {

        }   
    }
    public class LastNameException : Exception
    {
        public LastNameException(string messege) : base(messege)
        {

        }
    }
    public class MobileNumberException : Exception
    {
        public MobileNumberException(string messege) : base(messege)
        {

        }
    }
    public class EmailException : Exception
    {
        public EmailException(string messege) : base(messege)
        {

        }
    }
    public class PasswordException : Exception
    {
        public PasswordException(string messege) : base(messege)
        {

        }
    }


}
