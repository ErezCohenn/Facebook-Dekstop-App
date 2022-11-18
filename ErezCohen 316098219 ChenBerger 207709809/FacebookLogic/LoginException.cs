using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class LoginException : Exception
    {
        public LoginException() : base("Login process failed!!! please check that the App Id exist and you gave permissions") { }
    }
}
