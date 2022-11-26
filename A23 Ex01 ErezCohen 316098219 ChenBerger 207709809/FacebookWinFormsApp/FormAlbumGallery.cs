using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormAlbumGallery : Form
    {
        private readonly Album r_Album;

        public FormAlbumGallery(Album i_Album)
        {
            InitializeComponent();
            r_Album = i_Album;
            initializeGallery();
        }

        private void initializeGallery()
        {
            PhotoItem userPhotoItem = null;

            flowLayoutPanelAlbumGallery.Controls.Clear();
            try
            {
                foreach (Photo photo in r_Album.Photos)
                {
                    userPhotoItem = new PhotoItem(photo);
                    flowLayoutPanelAlbumGallery.Controls.Add(userPhotoItem);
                }
            }
            catch (ArgumentException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
