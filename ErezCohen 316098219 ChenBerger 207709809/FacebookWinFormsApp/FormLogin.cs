using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private bool m_FormClosedBySucceedLogin = false;
        FormAppSettings m_FormAppSettings;

        public FormLogin()
        {
            InitializeComponent();
            initializeUIDesign();
            m_FormAppSettings = new FormAppSettings();
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


        public bool IsFormClosedBySucceedLogin
        {
            get
            {
                return m_FormClosedBySucceedLogin;
            }
        }

        private void buttonSettings_Click(object sender, System.EventArgs e)
        {
            if (m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings();
            }

            m_FormAppSettings.ShowDialog();
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            if (m_FormAppSettings.AppSettings.AppID == null)
            {
                MessageBox.Show("AppId Not Selected! Please go to setting and insert AppId", "Login Failed");
            }
            else
            {
                /*m_LoginResult = FacebookService.Login(m_FormAppSettings.AppSettings.AppID, m_FormAppSettings.AppSettings.Permissions.ToArray());
                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    //fetchUserInfo();
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                }*/
            }
        }
    }
}
