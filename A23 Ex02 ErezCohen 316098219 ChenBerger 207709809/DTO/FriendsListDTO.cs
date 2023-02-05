using System;
using System.Collections.Generic;
using System.Drawing;

namespace DTO
{
    public class FriendsListDTO
    {
        private readonly List<KeyValuePair<string, Image>> r_FriendsList;

        public FriendsListDTO()
        {
            r_FriendsList = new List<KeyValuePair<string, Image>>();
        }

        public List<KeyValuePair<string, Image>> FriendsList { get => r_FriendsList; }

        public void AddFriend(string i_FriendName, string i_FriendImageURL)
        {
            try
            {
                Image friendImage = null;//Image.FromFile(i_FriendImageURL);
                r_FriendsList.Add(new KeyValuePair<string, Image>(i_FriendName, friendImage));
            }
            catch (Exception ignore)
            {
            }
        }
    }
}