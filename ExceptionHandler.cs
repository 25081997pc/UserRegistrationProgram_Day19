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
    }
}
