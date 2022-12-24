using FacebookLogic;

namespace BasicFacebookFeatures
{
    public class UIManager
    {
        private FormFacebookApp m_FormMain;
        private FormLogin m_FormLogin;
        private LogicManager m_LogicManager;

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
            m_LogicManager = LogicManager.Instance;

            if (!m_LogicManager.TryAutomaticLogin())
            {
                m_FormLogin = new FormLogin(m_LogicManager);
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
