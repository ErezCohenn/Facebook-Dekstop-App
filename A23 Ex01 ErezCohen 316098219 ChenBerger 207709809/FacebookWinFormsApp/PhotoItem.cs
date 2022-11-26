using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PhotoItem : ListItem
    {
        public PhotoItem(Photo i_Photo)
        {
            if (i_Photo.PictureNormalURL != null)
            {
                ImageURL = i_Photo.PictureNormalURL;
            }

            if (i_Photo.Name != null)
            {
                Title = i_Photo.Name;
            }
        }

        public PhotoItem()
        {
        }
    }
}
