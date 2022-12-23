using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.UserControlItems
{
    public static class ListItemFactory
    {
        public static ListItem CreateListItem(FacebookObject facebookObject)
        {
            ListItem listItem = null;

            if (facebookObject is Post)
            {
                listItem = new PostItem(facebookObject as Post);
            }
            else if (facebookObject is Album)
            {
                listItem = new AlbumItem(facebookObject as Album);
            }
            else if (facebookObject is Event)
            {
                listItem = new EventItem(facebookObject as Event);

            }
            else if (facebookObject is Photo)
            {
                listItem = new PhotoItem(facebookObject as Photo);
            }
            else if (facebookObject is GroupItem)
            {
                listItem = new GroupItem(facebookObject as Group);
            }
            else if (facebookObject is Page)
            {
                listItem = new PageItem(facebookObject as Page);
            }

            return listItem;
        }
    }
}
