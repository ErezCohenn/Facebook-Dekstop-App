using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;

namespace FacebookLogic
{
    public class LogicManager
    {
        private User m_CurrentUser;
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;

        public LogicManager()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_AppSettings = new AppSettings();
        }
        public void Login()
        {
            m_LoginResult = FacebookService.Login(m_AppSettings.AppID, m_AppSettings.Permissions.ToArray());
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new LoginException();
            }
        }
        public void Logout()
        {
            FacebookService.LogoutWithUI();
            m_AppSettings.ClearAccessToken();
        }
        public void AddPermission(string i_Permission)
        {
            m_AppSettings.AddPermission(i_Permission);
        }

        public void SetAppId(string i_AppId)
        {
            m_AppSettings.AppID = i_AppId;
        }
        private bool AlreadySignedIn()
        {
            return m_AppSettings.HasAccessToken();
        }
        public bool TryAutomaticLogin()
        {
            bool alreadySignedIn = AlreadySignedIn();
            if (alreadySignedIn)
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.GetAccessTokenFromFile());
                    m_CurrentUser = m_LoginResult.LoggedInUser;
                }
                catch (Exception exception)
                {
                    throw new LoginException();
                }
            }

            return alreadySignedIn;
        }
    }
}
