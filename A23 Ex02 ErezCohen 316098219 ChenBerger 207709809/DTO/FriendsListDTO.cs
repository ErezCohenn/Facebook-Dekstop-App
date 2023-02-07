using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace DTO
{
    public class FriendsListDTO : IEnumerable<KeyValuePair<string, Image>>
    {
        private readonly List<KeyValuePair<string, Image>> r_FriendsList;

        public FriendsListDTO()
        {
            r_FriendsList = new List<KeyValuePair<string, Image>>();
        }

        public List<KeyValuePair<string, Image>> FriendsList { get => r_FriendsList; }

        public void AddFriend(string i_FriendName, string i_FriendImageURL)
        {
            Image friendImage = null;

            try
            {
                friendImage = Image.FromFile(i_FriendImageURL);
            }
            finally
            {
                r_FriendsList.Add(new KeyValuePair<string, Image>(i_FriendName, friendImage));
            }
        }

        public IEnumerator<KeyValuePair<string, Image>> GetEnumerator()
        {
            foreach (KeyValuePair<string, Image> entry in FriendsList)
            {
                if (entry.Key != null)
                {
                    yield return entry;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}