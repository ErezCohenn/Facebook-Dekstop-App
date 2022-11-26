using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class GroupItem : ListItem
    {
        public GroupItem(Group i_Group)
        {
            if (i_Group.PictureSmallURL != null)
            {
                ImageURL = i_Group.PictureSmallURL;
            }

            if (i_Group.Name != null)
            {
                Title = i_Group.Name;
            }

            if (i_Group.Description != null)
            {
                Content = i_Group.Description;
            }

            if (i_Group.UpdateTime != null)
            {
                CreatedTime = i_Group.UpdateTime.Value;
            }
        }

        public GroupItem()
        {
        }
    }
}
