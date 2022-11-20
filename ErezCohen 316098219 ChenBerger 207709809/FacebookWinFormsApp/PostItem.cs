using FacebookWrapper.ObjectModel;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class PostItem : ListItem
    {

        public PostItem(Post i_Post)
        {
            if (i_Post.PictureURL != null)
            {
                Icon = Image.FromFile(i_Post.PictureURL);
            }
            if (i_Post.Caption != null)
            {
                Title = i_Post.Caption;
            }
            if (i_Post.Message != null)
            {
                Content = i_Post.Message;
            }
            if (i_Post.CreatedTime != null)
            {
                CreatedTime = i_Post.CreatedTime.Value;
            }
        }
    }
}
