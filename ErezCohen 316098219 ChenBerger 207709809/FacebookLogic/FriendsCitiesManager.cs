using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookLogic
{
    public class FriendsCitiesManager
    {
        private Dictionary<City, int> m_FriendsCities;

        public FriendsCitiesManager()
        {
            m_FriendsCities = new Dictionary<City, int>();
        }

        public void FetchFriendsCities(FacebookObjectCollection<User> i_FriendsList)
        {
            foreach (User friend in i_FriendsList)
            {
                if (m_FriendsCities.ContainsKey(friend.Hometown))
                {
                    m_FriendsCities[friend.Hometown]++;
                }
                else
                {
                    m_FriendsCities.Add(friend.Hometown, 1);
                }
            }
        }

        public Dictionary<City, int> GetFriendsCities()
        {
            return m_FriendsCities;
        }
    }
}
