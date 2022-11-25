using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumItem : ListItem
    {
        public AlbumItem(Album i_Album)
        {
            if (i_Album.PictureSmallURL != null)
            {
                //Icon = Image.Fr(i_Album.PictureSmallURL);
                ImageURL = i_Album.PictureSmallURL;
            }
            if (i_Album.Name != null)
            {
                Title = i_Album.Name;
            }
            if (i_Album.Message != null)
            {
                Content = i_Album.Message;
            }
            if (i_Album.CreatedTime != null)
            {
                CreatedTime = i_Album.CreatedTime.Value;
            }
        }

        public AlbumItem()
        {

        }
    }
}
