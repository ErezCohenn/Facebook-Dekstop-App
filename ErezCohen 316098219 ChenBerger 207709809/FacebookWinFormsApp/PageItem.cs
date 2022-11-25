
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PageItem : ListItem
    {
        public PageItem(Page i_Page)
        {
            if (i_Page.PictureSmallURL != null)
            {
                ImageURL = i_Page.PictureSmallURL;
            }
            if (i_Page.Name != null)
            {
                Title = i_Page.Name;
            }
            if (i_Page.Description != null)
            {
                Content = i_Page.Description;
            }
        }
        public PageItem()
        {

        }
    }
}
