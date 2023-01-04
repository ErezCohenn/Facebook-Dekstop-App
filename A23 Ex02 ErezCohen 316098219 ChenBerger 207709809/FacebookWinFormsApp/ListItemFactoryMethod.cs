using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class ListItemFactoryMethod
    {
        public static ListItem CreateListItem(FacebookObject i_FacebookObject)
        {
            ListItem listItem = null;

            if (i_FacebookObject is Post)
            {
                listItem = new PostItem(i_FacebookObject as Post);
            }
            else if (i_FacebookObject is Album)
            {
                listItem = new AlbumItem(i_FacebookObject as Album);
            }
            else if (i_FacebookObject is Event)
            {
                listItem = new EventItem(i_FacebookObject as Event);
            }
            else if (i_FacebookObject is Photo)
            {
                listItem = new PhotoItem(i_FacebookObject as Photo);
            }
            else if (i_FacebookObject is Group)
            {
                listItem = new GroupItem(i_FacebookObject as Group);
            }
            else if (i_FacebookObject is Page)
            {
                listItem = new PageItem(i_FacebookObject as Page);
            }

            return listItem;
        }
    }
}
