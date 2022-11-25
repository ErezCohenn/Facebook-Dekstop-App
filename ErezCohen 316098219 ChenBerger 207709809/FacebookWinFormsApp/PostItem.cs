using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class PostItem : ListItem
    {

        public PostItem(Post i_Post)
        {
            if (i_Post.PictureURL != null)
            {
                ImageURL = i_Post.PictureURL;
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

        public PostItem()
        {

        }
    }
}
