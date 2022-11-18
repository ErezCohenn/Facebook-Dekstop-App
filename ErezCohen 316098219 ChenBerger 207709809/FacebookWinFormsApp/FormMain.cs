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
        FormLogin m_FormLogin;

        public FormMain()
        {
            InitializeComponent();
            m_FormLogin = new FormLogin();
            this.m_FormLogin.FormClosed += new FormClosedEventHandler(this.FormLogin_FormClosed);
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {

            m_FormLogin = sender as FormLogin;

            if (e.CloseReason == CloseReason.UserClosing && !m_FormLogin.IsFormClosedBySucceedLogin)
            {
                this.Close();
            }
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_FormLogin.ShowDialog();
        }
    }
}
