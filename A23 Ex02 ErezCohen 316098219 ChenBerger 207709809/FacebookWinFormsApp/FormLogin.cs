using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private readonly LogicManager r_LogicManager;
        private readonly FormAppSettings r_FormAppSettings;
        private bool m_IsRememberMeCheckBoxChecked = false;
        private bool m_IsLoginSucceed = false;

        public bool IsLoginSucceed { get => m_IsLoginSucceed; }

        public FormLogin()
        {
            r_FormAppSettings = new FormAppSettings();
            r_LogicManager = LogicManager.Instance;
            InitializeComponent();
            initializeUIDesign();
            initializeSettings();
        }

        private void initializeSettings()
        {
            r_FormAppSettings.SetDefaultAppId();
            r_FormAppSettings.AddSelectedPremissions();
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
            r_FormAppSettings.ShowDialog();
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                r_LogicManager.RememberLastUser(m_IsRememberMeCheckBoxChecked);
                r_LogicManager.Login();
                m_IsLoginSucceed = true;
                this.Close();
            }
            catch (Facebook.FacebookOAuthException)
            {
            }
            catch (LoginException)
            {
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Notice: You must enter Permission and App Id.", "Login Failed");
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_IsRememberMeCheckBoxChecked = checkBoxRememberMe.Checked;
        }
    }
}
