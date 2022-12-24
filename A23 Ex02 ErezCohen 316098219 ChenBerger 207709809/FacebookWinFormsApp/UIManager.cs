using FacebookLogic;

namespace BasicFacebookFeatures
{
    public class UIManager
    {
        private FormFacebookApp m_FormMain;
        private FormLogin m_FormLogin;
        private readonly LoginFacade r_LoginFacade;

        public UIManager()
        {
            r_LoginFacade = new LoginFacade();
        }

        private void startFormMain()
        {
            m_FormMain = new FormFacebookApp();
            m_FormMain.ShowDialog();

            if (m_FormMain.IsLogoutButtonClicked)
            {
                StartApp();
            }
        }

        public void StartApp()
        {
            if (!r_LoginFacade.TryAutomaticLogin())
            {
                m_FormLogin = new FormLogin();
                m_FormLogin.ShowDialog();
                if (m_FormLogin.IsLoginSucceed)
                {
                    startFormMain();
                }
            }
            else
            {
                startFormMain();
            }
        }
    }
}
