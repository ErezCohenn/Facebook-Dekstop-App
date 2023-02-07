using System.Collections.Generic;
using System.Drawing;

namespace FacebookLogic
{
    public interface IComparer
    {
        bool ShouldSwap(KeyValuePair<string, Image> i_FirstFriend, KeyValuePair<string, Image> i_SecondFriend);
    }
}
