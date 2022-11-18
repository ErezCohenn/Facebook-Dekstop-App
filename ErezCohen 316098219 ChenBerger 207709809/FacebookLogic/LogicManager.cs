using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    class LogicManager
    {
        private User m_CurrentUser;
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;

        public LogicManager()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_AppSettings = new AppSettings();
        }
        public void LoginAndInit()
        {
            m_LoginResult = FacebookService.Login(m_AppSettings.AppID, m_AppSettings.Permissions.ToArray());

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new Exception("Login Failed");
            }
        }
        public void Logout()
        {
            FacebookService.LogoutWithUI();
        }
        public void AddPermission(string i_Permission)
        {
            m_AppSettings.AddPremission(i_Permission);
        }

    }
}
