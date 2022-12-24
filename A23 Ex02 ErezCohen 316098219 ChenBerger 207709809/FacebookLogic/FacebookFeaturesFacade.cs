using DTO;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookLogic
{
    public class FacebookFeaturesFacade
    {
        public FacebookObjectCollection<Page> FetchPages()
        {
            return LogicManager.Instance.FetchPages();
        }

        public Dictionary<string, int> FetchFriendsCities()
        {
            return LogicManager.Instance.FetchFriendsCities();
        }

        public FacebookObjectCollection<Post> FetchPosts()
        {
            return LogicManager.Instance.FetchPosts();
        }

        public FriendsListDTO FetchFriendsList()
        {
            return LogicManager.Instance.FetchFriendsList();
        }

        public FacebookObjectCollection<Group> FetchGroups()
        {
            return LogicManager.Instance.FetchGroups();
        }

        public FacebookObjectCollection<Album> FetchAlbums()
        {
            return LogicManager.Instance.FetchAlbums();
        }

        public FacebookObjectCollection<Event> FetchEventsByDate(DateTime i_DateTime)
        {
            return LogicManager.Instance.FetchEventsByDate(i_DateTime);
        }

        public void AddPost(string i_PostContent)
        {
            LogicManager.Instance.AddPost(i_PostContent);
        }

        public void Logout()
        {
            LogicManager.Instance.Logout();
        }

        public FacebookObjectCollection<Event> FetchEvents()
        {
            return LogicManager.Instance.FetchEvents();
        }

        public User GetCurrentUser()
        {
            return LogicManager.Instance.CurrentUser;
        }
    }
}
