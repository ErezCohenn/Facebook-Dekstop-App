using System;

namespace FacebookLogic
{
    public class LoginException : Exception
    {
        private const string k_Messege = "Login process failed!!! please check that the App Id exist and you gave permissions";

        public LoginException() : base(k_Messege)
        {
        }
    }
}
