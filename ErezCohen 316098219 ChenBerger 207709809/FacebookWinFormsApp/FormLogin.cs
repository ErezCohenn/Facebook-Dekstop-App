using FacebookLogic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private bool m_IsFormClosedBySucceedLogin = false;
        private LogicManager m_LogicManager;
        private FormAppSettings m_FormAppSettings;

        public FormLogin(LogicManager i_LogicManager)
        {
            InitializeComponent();
            initializeUIDesign();
            m_FormAppSettings = new FormAppSettings(i_LogicManager);
            m_LogicManager = i_LogicManager;
        }

        private void initializeUIDesign()
        {
            Bitmap bitmap;
            Color facebookBackgroundColor;

            pictureBoxFacebook.Image = Image.FromFile(Resources.FacebookLoginFullPath);
            pictureBoxFacebook.Enabled = false;
            pictureBoxFacebook.SizeMode = PictureBoxSizeMode.StretchImage;
            bitmap = new Bitmap(pictureBoxFacebook.ClientSize.Width, pictureBoxFacebook.Height);
            pictureBoxFacebook.DrawToBitmap(bitmap, pictureBoxFacebook.ClientRectangle);
            facebookBackgroundColor = bitmap.GetPixel(1, 1);
            this.BackColor = facebookBackgroundColor;
            bitmap.Dispose();
        }

        private void buttonQuit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public bool IsFormClosedBySucceedLogin { get => m_IsFormClosedBySucceedLogin; }

        private void buttonSettings_Click(object sender, System.EventArgs e)
        {
            if (m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings(m_LogicManager);
            }

            m_FormAppSettings.ShowDialog();
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                m_LogicManager.Login();
                m_IsFormClosedBySucceedLogin = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed");
            }
        }
    }
}
