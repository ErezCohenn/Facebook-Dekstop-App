using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class EventItem : ListItem
    {
        public EventItem(Event i_Event)
        {
            if (i_Event.PictureSmallURL != null)
            {
                ImageURL = i_Event.PictureSmallURL;
            }
            if (i_Event.Name != null)
            {
                Title = i_Event.Name;
            }
            if (i_Event.Description != null)
            {
                Content = i_Event.Description;
            }
            if (i_Event.StartTime != null)
            {
                CreatedTime = i_Event.StartTime.Value;
            }
        }

        public EventItem()
        {

        }
    }
}
