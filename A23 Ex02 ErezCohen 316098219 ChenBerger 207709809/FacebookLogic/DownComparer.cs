using System.Collections.Generic;
using System.Drawing;

namespace FacebookLogic
{
    public class DownComparer : IComparer
    {
        public bool ShouldSwap(KeyValuePair<string, Image> i_FirstFriend, KeyValuePair<string, Image> i_SecondFriend)
        {
            return string.Compare(i_FirstFriend.Key, i_SecondFriend.Key) < 0;
        }
    }
}