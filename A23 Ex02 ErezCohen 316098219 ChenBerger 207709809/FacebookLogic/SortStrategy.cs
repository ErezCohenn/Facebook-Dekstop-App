using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace FacebookLogic
{
    public class SortStrategy
    {
        public IComparer Comparer { get; set; }

        public SortStrategy()
        {
        }

        public void Sort(List<KeyValuePair<string, Image>> i_Friends)
        {
            for (int g = i_Friends.Count / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Friends.Count; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (Comparer.ShouldSwap(i_Friends[j], i_Friends[j + g]))
                        {
                            doSwap(i_Friends[j], i_Friends[j + g]);
                        }
                    }
                }
            }
        }

        private void doSwap(KeyValuePair<string, Image> i_FirstFriend, KeyValuePair<string, Image> i_SecondFriend)
        {
            KeyValuePair<string, Image> temp = i_FirstFriend;
            i_FirstFriend = i_SecondFriend;
            i_SecondFriend = temp;
        }
    }

    public interface IComparer
    {
        bool ShouldSwap(KeyValuePair<string, Image> i_FirstFriend, KeyValuePair<string, Image> i_SecondFriend);
    }

    public class DownComparer : IComparer
    {
        public bool ShouldSwap(KeyValuePair<string, Image> i_FirstFriend, KeyValuePair<string, Image> i_SecondFriend)
        {
            return string.Compare(i_FirstFriend.Key, i_SecondFriend.Key) > 0;
        }
    }

    public class UpComparer : IComparer
    {
        public bool ShouldSwap(KeyValuePair<string, Image> i_FirstFriend, KeyValuePair<string, Image> i_SecondFriend)
        {
            return string.Compare(i_FirstFriend.Key, i_SecondFriend.Key) <= 0;
        }
    }
}

