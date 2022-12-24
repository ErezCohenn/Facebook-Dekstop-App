namespace FacebookLogic
{
    public class LoginFacade
    {
        public void Login()
        {
            LogicManager.Instance.Login();
        }

        public void RememberLastUser(bool i_IsRememberMeCheckBoxChecked)
        {
            LogicManager.Instance.RememberLastUser(i_IsRememberMeCheckBoxChecked);
        }

        public bool TryAutomaticLogin()
        {
            return LogicManager.Instance.TryAutomaticLogin();
        }
    }
}