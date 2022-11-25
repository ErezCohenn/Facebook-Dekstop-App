using DTO;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FacebookLogic
{
    public class LogicManager
    {
        private User m_CurrentUser;
        private AppSettings m_AppSettings;
        private LoginResult m_LoginResult;
        private FriendsCitiesManager m_FriendsCitiesManager;

        public LogicManager()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_AppSettings = AppSettings.LoadFromFile();
            m_FriendsCitiesManager = new FriendsCitiesManager();
        }

        public void Login()
        {
            m_LoginResult = m_AppSettings.Permissions.Count > 0 ? FacebookService.Login(m_AppSettings.AppID, m_AppSettings.Permissions.ToArray()) :
                FacebookService.Login(m_AppSettings.AppID);
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
                if (m_AppSettings.RememberUser)
                {
                    m_AppSettings.SaveToFile(m_LoginResult.AccessToken);
                }
            }
            else
            {
                throw new LoginException();
            }
        }

        internal FacebookObjectCollection<User> FetchFriends()
        {
            return m_CurrentUser.Friends;
        }

        public string FetchUserProfileImageUrl()
        {
            return m_CurrentUser.PictureNormalURL;
        }
        public FacebookObjectCollection<Page> FetchLikedPages()
        {
            return m_CurrentUser.LikedPages;
        }
        public Page[] FetchFavoriteTeams()
        {
            return m_CurrentUser.FavofriteTeams;
        }
        public void Logout()
        {
            FacebookService.LogoutWithUI();
            forgetUser();
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

        public FriendsListDTO FetchFriendsList()
        {
            FriendsListDTO friendsListDTO = new FriendsListDTO();
            FacebookObjectCollection<User> friendsList = m_CurrentUser.Friends;

            foreach (User friend in friendsList)
            {
                friendsListDTO.AddFriend(friend.Name, friend.PictureSmallURL);
            }

            return friendsListDTO;
        }
        public FriendsListDTO FetchSameHomeTownFriends()
        {
            FriendsListDTO sameHomeTownfriendsListDTO = new FriendsListDTO();
            FacebookObjectCollection<User> friendsList = m_CurrentUser.Friends;

            foreach (User friend in friendsList)
            {
                if (friend.Hometown == m_CurrentUser.Hometown)
                {
                    sameHomeTownfriendsListDTO.AddFriend(friend.Name, friend.PictureSmallURL);
                }
            }

            return sameHomeTownfriendsListDTO;
        }
        public ProfileDataDTO FetchProfileData()
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

        //private bool AlreadySignedIn()
        //{
        //    return m_AppSettings.WantedToRememberUser();
        //}
        public bool TryAutomaticLogin()
        {
            bool alreadySignedIn = m_AppSettings.RememberUser;

            if (alreadySignedIn)
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    m_CurrentUser = m_LoginResult.LoggedInUser;
                }
                catch (Exception exception)
                {
                    alreadySignedIn = false;
                }
            }

            return alreadySignedIn;
        }

        public void RememberLastUser(bool i_CheckBoxState)
        {
            m_AppSettings.RememberUser = i_CheckBoxState;
        }
        private void forgetUser()
        {
            m_AppSettings.RememberUser = false;
            m_AppSettings.SaveToFile(m_AppSettings.LastAccessToken);
        }

        public void AddPost(string i_PostContent)
        {
            Status postedStatus = null;

            try
            {
                postedStatus = m_CurrentUser.PostStatus(i_PostContent);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            FacebookObjectCollection<Post> posts = null;
            try
            {
                posts = m_CurrentUser.Posts;
            }
            catch (Facebook.FacebookOAuthException ex) { }
            return posts != null ? posts : null;
        }

        public FacebookObjectCollection<Event> FetchEvents()
        {
            return m_CurrentUser.Events;
        }

        public FacebookObjectCollection<Group> FetchGroups()
        {
            return m_CurrentUser.Groups;
        }

        public FacebookObjectCollection<Album> FetchAlbums()
        {
            return m_CurrentUser.Albums;
        }

        public Dictionary<string, int> FetchFriendsCities()
        {
            m_FriendsCitiesManager.FetchFriendsCities(m_CurrentUser.Friends);

            return m_FriendsCitiesManager.GetFriendsCities();
        }
    }
}
