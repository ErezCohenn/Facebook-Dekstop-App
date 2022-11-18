using FacebookLogic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FormLogin m_FormLogin;
        LogicManager m_LogicManager;

        public FormMain()
        {
            InitializeComponent();
            m_LogicManager = new LogicManager();
            m_FormLogin = new FormLogin(m_LogicManager);
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
            //todo
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_FormLogin.ShowDialog();
        }
    }
}
