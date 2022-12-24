using DTO;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookLogic
{
    public sealed class LogicManager
    {
        private static LogicManager s_Instance = null;
        private static object s_LockObj = new object();
        private readonly FriendsCitiesManager r_FriendsCitiesManager;
        private readonly AppSettings r_AppSettings;
        private User m_CurrentUser;
        private LoginResult m_LoginResult;

        public static LogicManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new LogicManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User CurrentUser { get => m_CurrentUser; }

        private LogicManager()
        {
            FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
            r_FriendsCitiesManager = new FriendsCitiesManager();
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(r_AppSettings.AppID, r_AppSettings.Permissions.ToArray());
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_CurrentUser = m_LoginResult.LoggedInUser;
                if (r_AppSettings.RememberUser)
                {
                    r_AppSettings.SaveToFile(m_LoginResult.AccessToken);
                }
            }
            else
            {
                throw new LoginException();
            }
        }

        public string FetchUserProfileImageUrl()
        {
            return m_CurrentUser.PictureNormalURL;
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
            r_AppSettings.AddPermission(i_Permission);
        }

        public void SetAppId(string i_AppId)
        {
            r_AppSettings.AppID = i_AppId;
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

        public bool TryAutomaticLogin()
        {
            bool alreadySignedIn = r_AppSettings.RememberUser;

            if (alreadySignedIn)
            {
                try
                {
                    m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                    m_CurrentUser = m_LoginResult.LoggedInUser;
                }
                catch (Exception)
                {
                    alreadySignedIn = false;
                }
            }

            return alreadySignedIn;
        }

        public void RememberLastUser(bool i_CheckBoxState)
        {
            r_AppSettings.RememberUser = i_CheckBoxState;
        }

        private void forgetUser()
        {
            r_AppSettings.RememberUser = false;
            r_AppSettings.SaveToFile(r_AppSettings.LastAccessToken);
        }

        public void AddPost(string i_PostContent)
        {
            m_CurrentUser.PostStatus(i_PostContent);
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            FacebookObjectCollection<Post> posts = new FacebookObjectCollection<Post>();

            try
            {
                posts = m_CurrentUser.Posts;
            }
            catch (Facebook.FacebookOAuthException)
            {
            }

            return posts;
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
            r_FriendsCitiesManager.FetchFriendsCities(m_CurrentUser.Friends);

            return r_FriendsCitiesManager.GetFriendsCities();
        }

        public FacebookObjectCollection<Page> FetchPages()
        {
            return m_CurrentUser.LikedPages;
        }

        public FacebookObjectCollection<Event> FetchEventsByDate(DateTime date)
        {
            FacebookObjectCollection<Event> events = FetchEvents();
            FacebookObjectCollection<Event> eventsAfterFilterByDate = new FacebookObjectCollection<Event>();

            foreach (Event eventToCheck in events)
            {
                if (eventToCheck.StartTime.Value.Equals(date))
                {
                    eventsAfterFilterByDate.Add(eventToCheck);
                }
            }

            return eventsAfterFilterByDate;
        }
    }
}
