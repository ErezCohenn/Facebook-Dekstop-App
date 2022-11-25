using BasicFacebookFeatures;
using DTO;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FacebookLogic.DummyData
{
    public class DummyFactory
    {
        private static List<AlbumItem> m_AlbumItems;
        private static List<GroupItem> m_GroupItems;
        private static List<PostItem> m_PostItems;
        private static List<EventItem> m_EventItems;
        private static FriendsListDTO m_FriendsListDTO;
        private static Dictionary<string, int> m_FriendsCities;

        static DummyFactory()
        {
            m_AlbumItems = new List<AlbumItem>();
            m_GroupItems = new List<GroupItem>();
            m_PostItems = new List<PostItem>();
            m_EventItems = new List<EventItem>();
            m_FriendsListDTO = new FriendsListDTO();
            m_FriendsCities = new Dictionary<string, int>();
            createDummyData();
        }

        public static List<AlbumItem> AlbumItems { get => m_AlbumItems; set => m_AlbumItems = value; }
        public static List<GroupItem> GroupItem { get => m_GroupItems; set => m_GroupItems = value; }
        public static List<PostItem> PostItem { get => m_PostItems; set => m_PostItems = value; }
        public static List<EventItem> EventItem { get => m_EventItems; set => m_EventItems = value; }
        public static FriendsListDTO FriendsListDTO { get => m_FriendsListDTO; set => m_FriendsListDTO = value; }
        public static Dictionary<string, int> FriendsCities { get => m_FriendsCities; set => m_FriendsCities = value; }

        private static void createDummyData()
        {
            AlbumItem currentAlbum = null;
            PostItem currentPost = null;
            EventItem currentEvent = null;
            User currentUser = null;
            GroupItem currentGroup = null;
            Image image = Image.FromFile("C:/Users/erez6/Desktop/לימודים/אקדמית יפו/שנה ג/Design Patterns/Facebook-Dekstop-App/ErezCohen 316098219 ChenBerger 207709809/FacebookWinFormsApp/Resources/facebookLogo.png"); ;

            for (int i = 0; i < 10; i++)
            {
                currentAlbum = new AlbumItem();
                currentAlbum.Title = string.Format("album{0}", i);
                currentAlbum.Content = string.Format("dummy messge {0}", i);
                currentAlbum.CreatedTime = DateTime.Now;
                currentAlbum.Icon = image;
                m_AlbumItems.Add(currentAlbum);

                currentPost = new PostItem();
                currentPost.Title = string.Format("post{0}", i);
                currentPost.Content = string.Format("post{0}", i);
                currentPost.CreatedTime = DateTime.Now;
                currentPost.Icon = image;
                m_PostItems.Add(currentPost);

                currentEvent = new EventItem();
                currentEvent.Title = string.Format("event{0}", i);
                currentEvent.Content = string.Format("event{0}", i);
                currentEvent.CreatedTime = DateTime.Now;
                currentEvent.Icon = image;
                m_EventItems.Add(currentEvent);

                currentGroup = new GroupItem();
                currentGroup.Title = string.Format("Group{0}", i);
                currentGroup.Content = string.Format("evGroupent{0}", i);
                currentGroup.CreatedTime = DateTime.Now;
                currentGroup.Icon = image;
                m_GroupItems.Add(currentGroup);

                m_FriendsListDTO.AddFriend(string.Format("friend {0}", i), "C:/Users/erez6/Desktop/לימודים/אקדמית יפו/שנה ג/Design Patterns/Facebook-Dekstop-App/ErezCohen 316098219 ChenBerger 207709809/FacebookWinFormsApp/Resources/facebookLogo.png");
                City city = new City();
                m_FriendsCities.Add("city" + i.ToString(), i + 1);
            }
        }
    }
}
