using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

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
            UserPhotoItem userPhotoItem = null;

            flowLayoutPanelAlbumGallery.Controls.Clear();
            try
            {
                foreach (Photo photo in r_Album.Photos)
                {
                    userPhotoItem = new UserPhotoItem(photo);
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
