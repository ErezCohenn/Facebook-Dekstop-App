using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public abstract partial class ListItem : UserControl
    {

        private string m_ImageURL;
        private string m_Content;
        private string m_Title;
        private DateTime m_CreatedTime;

        public ListItem()
        {
            InitializeComponent();
        }

        public string ImageURL
        {
            get => m_ImageURL;
            set
            {
                m_ImageURL = value;
                pictureBoxImage.ImageLocation = value;
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
