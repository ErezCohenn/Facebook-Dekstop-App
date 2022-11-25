using FacebookLogic;
using System;
using System.Text;
using System.Windows.Forms;
namespace BasicFacebookFeatures
{
    public partial class FormAppSettings : Form
    {
        private LogicManager m_LogicManager;
        private StringBuilder m_PermissionsStringBuilder = new StringBuilder();

        public FormAppSettings(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_LogicManager = i_LogicManager;
        }


        private void buttonRefreshPermissions_Click(object sender, EventArgs e)
        {
            textBoxPermissions.Clear();
            m_PermissionsStringBuilder.Clear();
            foreach (var checkedItem in listBoxPermissions.CheckedItems)
            {
                m_PermissionsStringBuilder.Append($"\"{checkedItem}\",");
            }

            textBoxPermissions.Text = m_PermissionsStringBuilder.ToString();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboAppID.SelectedIndex == -1)
            {
                MessageBox.Show("AppId not selected!", "Apply Settings Failed");
            }
            else
            {
                m_LogicManager.SetAppId(comboAppID.SelectedItem.ToString());
                addSelectedPremissions();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void addSelectedPremissions()
        {
            CheckState permissionCheckState;

            for (int i = 0; i < listBoxPermissions.Items.Count; i++)
            {
                permissionCheckState = listBoxPermissions.GetItemCheckState(i);
                if (permissionCheckState == CheckState.Checked)
                {
                    m_LogicManager.AddPermission(listBoxPermissions.Items[i].ToString());
                }
            }
        }

        private void buttonAddPermission_Click(object sender, EventArgs e)
        {
            listBoxPermissions.Items.Add(textBoxPermissionToAdd.Text);
        }

        private void buttonAddAppID_Click(object sender, EventArgs e)
        {
            comboAppID.Items.Insert(0, textBoxAppID.Text);
            comboAppID.SelectedIndex = 0;
        }
    }
}
