namespace FacebookLogic
{
    public class LoginFacade
    {
        private readonly LogicManager r_LogicManager;

        public LoginFacade()
        {
            r_LogicManager = LogicManager.Instance;
        }

        public void Login()
        {
            r_LogicManager.Login();
        }

        public void RememberLastUser(bool i_IsRememberMeCheckBoxChecked)
        {
            r_LogicManager.RememberLastUser(i_IsRememberMeCheckBoxChecked);
        }

        public bool TryAutomaticLogin()
        {
            return r_LogicManager.TryAutomaticLogin();
        }
    }
}