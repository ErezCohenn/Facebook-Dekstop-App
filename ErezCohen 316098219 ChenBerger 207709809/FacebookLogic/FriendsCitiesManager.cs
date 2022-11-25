using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FacebookLogic
{
    public class FriendsCitiesManager
    {
        private Dictionary<string, int> m_FriendsCities;

        public FriendsCitiesManager()
        {
            m_FriendsCities = new Dictionary<string, int>();
        }

        public void FetchFriendsCities(FacebookObjectCollection<User> i_FriendsList)
        {
            foreach (User friend in i_FriendsList)
            {
                if (friend.Hometown != null && friend.Hometown.Location != null && friend.Hometown.Location.City != null)
                {
                    if (m_FriendsCities.ContainsKey(friend.Hometown.Location.City.ToString()))
                    {
                        m_FriendsCities[friend.Hometown.Location.City.ToString()]++;
                    }
                    else
                    {
                        m_FriendsCities.Add(friend.Hometown.Location.City.ToString(), 1);
                    }
                }
            }
        }

        public Dictionary<string, int> GetFriendsCities()
        {
            return m_FriendsCities;
        }
    }
}
