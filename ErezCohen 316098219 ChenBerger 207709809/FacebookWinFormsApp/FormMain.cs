using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;
        LoginResult m_LoginResult;
        FormAppSettings m_FormAppSettings;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            if (m_FormAppSettings.AppSettings.AppID == null)
            {
                MessageBox.Show("AppId Not Selected! Please go to setting and insert AppId", "Login Failed");
            }
            else
            {

                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    //fetchUserInfo();
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            buttonLogin.Text = "Login";
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings();
            }

            m_FormAppSettings.ShowDialog();
        }
    }
}
