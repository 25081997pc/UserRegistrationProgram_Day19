using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ExceptionHandler
    {
        public void firstname()
        {
            throw (new FirstNameException("First Name pattern is wrong:First letter should be capital and it should have minimum 3 characters"));
        }
        public void lastname()
        {
            throw (new LastNameException("last Name pattern is wrong:First letter should be capital and it should have minimum 3 characters"));
        }
        public void mobilenumber()
        {
            throw (new MobileNumberException("Mobile Format is wrong: Mobile Number should have country code and 10 numbers"));
        }
    }
}
