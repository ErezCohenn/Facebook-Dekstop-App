using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class ListItem : UserControl
    {

        private Image m_Image;
        private string m_Content;
        private string m_Title;
        private DateTime m_CreatedTime;

        public ListItem()
        {
            InitializeComponent();
        }

        public Image Icon
        {
            get => m_Image;
            set
            {
                m_Image = value;
                pictureBoxImage.Image = m_Image;
            }
        }

        public string Content
        {
            get => m_Content;
            set
            {
                m_Content = value;
                labelContent.Text = m_Content;
            }
        }

        public string Title
        {
            get => m_Title;
            set
            {
                m_Title = value;
                labelTitle.Text = m_Title;
            }
        }

        public DateTime CreatedTime
        {
            get => m_CreatedTime;
            set
            {
                m_CreatedTime = value;
                labelCreatedTime.Text = m_CreatedTime.ToString();
            }
        }
    }
}
