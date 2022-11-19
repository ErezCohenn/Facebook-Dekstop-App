using FacebookLogic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private bool m_IsRememberMeCheckBoxChecked = false;
        private bool m_IsLoginSucceed = false;
        private LogicManager m_LogicManager;
        private FormAppSettings m_FormAppSettings;

        public bool IsLoginSucceed { get => m_IsLoginSucceed; }

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
                m_LogicManager.RememberLastUser(m_IsRememberMeCheckBoxChecked);
                m_LogicManager.Login();
                m_IsLoginSucceed = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login process failed!!! please check that the App Id exist and you gave permissions", "Login Failed");
            }
        }
        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_IsRememberMeCheckBoxChecked = checkBoxRememberMe.Checked;
        }
    }
}
