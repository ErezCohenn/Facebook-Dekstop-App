using DTO;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookLogic
{
    public class FacebookFeaturesFacade
    {

        private readonly LogicManager r_LogicManager;

        public FacebookFeaturesFacade()
        {
            r_LogicManager = LogicManager.Instance;
        }
        public FacebookObjectCollection<Page> FetchPages()
        {
            return r_LogicManager.FetchPages();
        }

        public Dictionary<string, int> FetchFriendsCities()
        {
            return r_LogicManager.FetchFriendsCities();
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            return r_LogicManager.FetchPosts();
        }

        public FriendsListDTO FetchFriendsList()
        {
            return r_LogicManager.FetchFriendsList();
        }

        public FacebookObjectCollection<Group> FetchGroups()
        {
            return r_LogicManager.FetchGroups();
        }

        public FacebookObjectCollection<Album> FetchAlbums()
        {
            return r_LogicManager.FetchAlbums();
        }

        public FacebookObjectCollection<Event> FetchEventsByDate(DateTime i_DateTime)
        {
            return r_LogicManager.FetchEventsByDate(i_DateTime);
        }

        public void AddPost(string i_PostContent)
        {
            r_LogicManager.AddPost(i_PostContent);
        }

        public void Logout()
        {
            r_LogicManager.Logout();
        }

        public FacebookObjectCollection<Event> FetchEvents()
        {
            return r_LogicManager.FetchEvents();
        }

        public User GetCurrentUser()
        {
            return r_LogicManager.CurrentUser;
        }
    }
}
