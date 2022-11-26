using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumItem : ListItem
    {
        private readonly Album r_Album;
        public AlbumItem(Album i_Album)
        {
            r_Album = i_Album;
            if (i_Album.PictureSmallURL != null)
            {
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
            initializePhotosLinkLabel();
        }

        public AlbumItem()
        {
        }

        private void initializePhotosLinkLabel()
        {
            LinkLabel photosLinkLabel = new LinkLabel();

            photosLinkLabel.AutoSize = true;
            photosLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)177);
            photosLinkLabel.Location = new System.Drawing.Point(25, 160);
            photosLinkLabel.Name = "photosLinkLabel";
            photosLinkLabel.Size = new System.Drawing.Size(72, 17);
            photosLinkLabel.TabIndex = 4;
            photosLinkLabel.UseMnemonic = false;
            photosLinkLabel.TabStop = true;
            photosLinkLabel.Text = string.Format("Pictures: ({0})", r_Album.Photos.Count);
            photosLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabelPhotos_LinkClicked);
            base.Controls.Add(photosLinkLabel);
        }

        private void linkLabelPhotos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAlbumGallery formAlbumGallery = null;

            if (r_Album.Photos.Count > 0)
            {
                formAlbumGallery = new FormAlbumGallery(r_Album);
                formAlbumGallery.ShowDialog();
            }
        }
    }
}