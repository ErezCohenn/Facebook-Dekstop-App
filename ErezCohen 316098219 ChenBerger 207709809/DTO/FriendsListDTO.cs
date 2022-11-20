using System.Collections.Generic;
using System.Drawing;

namespace DTO
{
    public class FriendsListDTO
    {
        private List<KeyValuePair<string, Image>> friendsList;

        public FriendsListDTO()
        {
            friendsList = new List<KeyValuePair<string, Image>>();
        }

        public List<KeyValuePair<string, Image>> FriendsList { get => friendsList; }

        public void AddFriend(string i_FriendName, string i_FriendImageURL)
        {
            Image friendImage = Image.FromFile(i_FriendImageURL);

            friendsList.Add(new KeyValuePair<string, Image>(i_FriendName, friendImage));
        }
    }
}
