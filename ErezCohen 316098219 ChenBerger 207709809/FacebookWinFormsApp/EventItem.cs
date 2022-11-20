using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class EventItem : ListItem
    {
        public EventItem(Event i_Event)
        {
            if (i_Event.PictureNormalURL != null)
            {
                Icon = Image.FromFile(i_Event.PictureNormalURL);
            }
            if (i_Event.Name != null)
            {
                Title = i_Event.Name;
            }
            if (i_Event.Description != null)
            {
                Content = i_Event.Description;
            }
            if (i_Event.UpdateTime != null)
            {
                CreatedTime = i_Event.UpdateTime.Value;
            }
        }
    }
}
