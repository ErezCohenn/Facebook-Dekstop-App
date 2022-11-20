

using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class AlbumItem : ListItem
    {
        public AlbumItem(Album i_Album)
        {
            if (i_Album.PictureAlbumURL != null)
            {
                Icon = Image.FromFile(i_Album.PictureAlbumURL);
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
    }
}
