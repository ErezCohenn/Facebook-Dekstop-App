﻿using System;
using System.Text;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormAppSettings : Form
    {
        private static readonly string sr_DefaultAppId = "852667072827918";
        private readonly LogicManager r_LogicManager;
        private readonly StringBuilder r_Permissions;

        public FormAppSettings(LogicManager i_LogicManager)
        {
            InitializeComponent();
            r_Permissions = new StringBuilder();
            r_LogicManager = i_LogicManager;
        }

        private void buttonRefreshPermissions_Click(object sender, EventArgs e)
        {
            textBoxPermissions.Clear();
            r_Permissions.Clear();
            foreach (var checkedItem in listBoxPermissions.CheckedItems)
            {
                r_Permissions.Append($"\"{checkedItem}\",");
            }

            textBoxPermissions.Text = r_Permissions.ToString();
        }

        public void SetDefaultAppId()
        {
            r_LogicManager.SetAppId(sr_DefaultAppId);
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (comboAppID.SelectedIndex == -1)
            {
                MessageBox.Show("AppId not selected!", "Apply Settings Failed");
            }
            else
            {
                r_LogicManager.SetAppId(comboAppID.SelectedItem.ToString());
                AddSelectedPremissions();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void AddSelectedPremissions()
        {
            CheckState permissionCheckState;

            for (int i = 0; i < listBoxPermissions.Items.Count; i++)
            {
                permissionCheckState = listBoxPermissions.GetItemCheckState(i);
                if (permissionCheckState == CheckState.Checked)
                {
                    r_LogicManager.AddPermission(listBoxPermissions.Items[i].ToString());
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

        private void FormAppSettings_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxPermissions.Items.Count; i++)
            {
                listBoxPermissions.SetItemChecked(i, true);
            }
        }
    }
}