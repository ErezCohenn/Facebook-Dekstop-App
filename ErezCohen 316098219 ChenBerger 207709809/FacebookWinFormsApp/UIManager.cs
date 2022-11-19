using FacebookLogic;

namespace BasicFacebookFeatures
{
    public class UIManager
    {
        private FormMain m_FormMain;
        private FormLogin m_FormLogin;
        private LogicManager m_LogicManager;

        private void startFormMain()
        {
            m_FormMain = new FormMain(m_LogicManager);
            m_FormMain.ShowDialog();

            if (m_FormMain.IsLogoutButtonClicked)
            {
                StartApp();
            }
        }

        public void StartApp()
        {
            m_LogicManager = new LogicManager();
            m_FormLogin = new FormLogin(m_LogicManager);
            m_FormLogin.ShowDialog();

            if (m_FormLogin.IsLoginSucceed)
            {
                startFormMain();
            }
        }
    }
}
