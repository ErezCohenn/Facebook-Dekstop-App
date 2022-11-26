using System.Collections.Generic;
using System.Drawing;

namespace DTO
{
    public class FriendsListDTO
    {
        private List<KeyValuePair<string, Image>> m_FriendsList;

        public FriendsListDTO()
        {
            m_FriendsList = new List<KeyValuePair<string, Image>>();
        }

        public List<KeyValuePair<string, Image>> FriendsList { get => m_FriendsList; }

        public void AddFriend(string i_FriendName, string i_FriendImageURL)
        {
            Image friendImage = Image.FromFile(i_FriendImageURL);

            m_FriendsList.Add(new KeyValuePair<string, Image>(i_FriendName, friendImage));
        }
    }
}
