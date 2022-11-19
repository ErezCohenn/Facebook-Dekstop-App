using DTO;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using DTO;
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
            m_LoginResult = m_AppSettings.Permissions.Count > 0 ? FacebookService.Login(m_AppSettings.AppID, m_AppSettings.Permissions.ToArray()) :
                FacebookService.Login(m_AppSettings.AppID);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                throw new LoginException();
            }
        }

        public string GetUserProfileImageUrl()
        {
            return m_CurrentUser.PictureNormalURL;
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
            ForgetUser();
            m_LoginResult = null;
            m_CurrentUser = null;
        }

        public void AddPermission(string i_Permission)
        {
            m_AppSettings.AddPermission(i_Permission);
        }

        public void SetAppId(string i_AppId)
        {
            m_AppSettings.AppID = i_AppId;
        }

        public FriendsListDTO GetFriendsList()
        {
            FriendsListDTO friendsListDTO = new FriendsListDTO();
            FacebookObjectCollection<User> friendsList = m_CurrentUser.Friends;

            foreach (User friend in friendsList)
            {
                friendsListDTO.AddFriend(friend.Name, friend.PictureSmallURL);
            }

            return friendsListDTO;
        }

        public ProfileDataDTO GetProfileData()
        {
            ProfileDataDTO profileDataDTO = new ProfileDataDTO();

            profileDataDTO.FirstName = m_CurrentUser.FirstName;
            profileDataDTO.LastName = m_CurrentUser.LastName;
            profileDataDTO.Birthday = m_CurrentUser.Birthday;
            profileDataDTO.HomeTown = m_CurrentUser.Hometown;
            profileDataDTO.Email = m_CurrentUser.Email;
            profileDataDTO.About = m_CurrentUser.About;

            return profileDataDTO;
        }

        private bool AlreadySignedIn()
        {
            return m_AppSettings.WantedToRememberUser();
        }
        public bool TryAutomaticLogin()
        {
            bool alreadySignedIn = AlreadySignedIn();
            if (alreadySignedIn)
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LoadFromFile());
                    m_CurrentUser = m_LoginResult.LoggedInUser;
                }
                catch (Exception exception)
                {
                    throw new LoginException();
                }
            }

            return alreadySignedIn;
        }
        
        public void RememberLastUser(bool i_CheckBoxState)
        {
            m_AppSettings.RememberUser = i_CheckBoxState;
        }
        private void ForgetUser()
        {
            m_AppSettings.RememberUser = false;
        }
    }
}
