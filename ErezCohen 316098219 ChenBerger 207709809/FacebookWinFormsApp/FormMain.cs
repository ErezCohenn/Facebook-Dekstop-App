using FacebookWrapper;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "852667072827918",
                    /// requested permissions:
                    "email",
                    "public_profile"
                    /// add any relevant permissions
                    );

            buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }
    }
}
