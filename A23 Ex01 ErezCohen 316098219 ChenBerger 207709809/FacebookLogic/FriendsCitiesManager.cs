using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class FriendsCitiesManager
    {
        private readonly Dictionary<string, int> r_FriendsCities;

        public FriendsCitiesManager()
        {
            r_FriendsCities = new Dictionary<string, int>();
        }

        public void FetchFriendsCities(FacebookObjectCollection<User> i_FriendsList)
        {
            foreach (User friend in i_FriendsList)
            {
                if (friend.Hometown != null && friend.Hometown.Location != null && friend.Hometown.Location.City != null)
                {
                    if (r_FriendsCities.ContainsKey(friend.Hometown.Location.City.ToString()))
                    {
                        r_FriendsCities[friend.Hometown.Location.City.ToString()]++;
                    }
                    else
                    {
                        r_FriendsCities.Add(friend.Hometown.Location.City.ToString(), 1);
                    }
                }
            }
        }

        public Dictionary<string, int> GetFriendsCities()
        {
            return r_FriendsCities;
        }
    }
}
