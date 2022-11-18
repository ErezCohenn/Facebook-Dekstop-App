﻿
namespace BasicFacebookFeatures
{
    partial class FormAppSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboAppID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.textBoxPermissions = new System.Windows.Forms.TextBox();
            this.buttonRefreshPermissions = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxPermissionToAdd = new System.Windows.Forms.TextBox();
            this.buttonAddPermission = new System.Windows.Forms.Button();
            this.buttonAddAppID = new System.Windows.Forms.Button();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboAppID
            // 
            this.comboAppID.Items.AddRange(new object[] {
            "1450160541956417",
            "852667072827918"});
            this.comboAppID.Location = new System.Drawing.Point(84, 7);
            this.comboAppID.Margin = new System.Windows.Forms.Padding(4);
            this.comboAppID.Name = "comboAppID";
            this.comboAppID.Size = new System.Drawing.Size(203, 28);
            this.comboAppID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "APP ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Permissions:";
            // 
            // listBoxPermissions
            // 
            this.listBoxPermissions.CheckOnClick = true;
            this.listBoxPermissions.FormattingEnabled = true;
            this.listBoxPermissions.Items.AddRange(new object[] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_events",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"});
            this.listBoxPermissions.Location = new System.Drawing.Point(20, 69);
            this.listBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPermissions.Name = "listBoxPermissions";
            this.listBoxPermissions.Size = new System.Drawing.Size(384, 424);
            this.listBoxPermissions.Sorted = true;
            this.listBoxPermissions.TabIndex = 8;
            // 
            // textBoxPermissions
            // 
            this.textBoxPermissions.Location = new System.Drawing.Point(417, 69);
            this.textBoxPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissions.Multiline = true;
            this.textBoxPermissions.Name = "textBoxPermissions";
            this.textBoxPermissions.Size = new System.Drawing.Size(177, 382);
            this.textBoxPermissions.TabIndex = 9;
            // 
            // buttonRefreshPermissions
            // 
            this.buttonRefreshPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshPermissions.Location = new System.Drawing.Point(448, 458);
            this.buttonRefreshPermissions.Name = "buttonRefreshPermissions";
            this.buttonRefreshPermissions.Size = new System.Drawing.Size(123, 35);
            this.buttonRefreshPermissions.TabIndex = 10;
            this.buttonRefreshPermissions.Text = "Refresh";
            this.buttonRefreshPermissions.UseVisualStyleBackColor = true;
            this.buttonRefreshPermissions.Click += new System.EventHandler(this.buttonRefreshPermissions_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(459, 506);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(95, 35);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxPermissionToAdd
            // 
            this.textBoxPermissionToAdd.Location = new System.Drawing.Point(20, 512);
            this.textBoxPermissionToAdd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissionToAdd.Name = "textBoxPermissionToAdd";
            this.textBoxPermissionToAdd.Size = new System.Drawing.Size(203, 26);
            this.textBoxPermissionToAdd.TabIndex = 12;
            // 
            // buttonAddPermission
            // 
            this.buttonAddPermission.Location = new System.Drawing.Point(230, 506);
            this.buttonAddPermission.Name = "buttonAddPermission";
            this.buttonAddPermission.Size = new System.Drawing.Size(174, 37);
            this.buttonAddPermission.TabIndex = 13;
            this.buttonAddPermission.Text = "Add Permission";
            this.buttonAddPermission.UseVisualStyleBackColor = true;
            this.buttonAddPermission.Click += new System.EventHandler(this.buttonAddPermission_Click);
            // 
            // buttonAddAppID
            // 
            this.buttonAddAppID.Location = new System.Drawing.Point(505, 7);
            this.buttonAddAppID.Name = "buttonAddAppID";
            this.buttonAddAppID.Size = new System.Drawing.Size(49, 28);
            this.buttonAddAppID.TabIndex = 19;
            this.buttonAddAppID.Text = "Add";
            this.buttonAddAppID.UseVisualStyleBackColor = true;
            this.buttonAddAppID.Click += new System.EventHandler(this.buttonAddAppID_Click);
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(306, 7);
            this.textBoxAppID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(192, 26);
            this.textBoxAppID.TabIndex = 18;
            // 
            // FormAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 555);
            this.Controls.Add(this.buttonAddAppID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.buttonAddPermission);
            this.Controls.Add(this.textBoxPermissionToAdd);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonRefreshPermissions);
            this.Controls.Add(this.textBoxPermissions);
            this.Controls.Add(this.listBoxPermissions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAppID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormAppSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAppSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listBoxPermissions;
        private System.Windows.Forms.TextBox textBoxPermissions;
        private System.Windows.Forms.Button buttonRefreshPermissions;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxPermissionToAdd;
        private System.Windows.Forms.Button buttonAddPermission;
        private System.Windows.Forms.Button buttonAddAppID;
        private System.Windows.Forms.TextBox textBoxAppID;
    }
}