
namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.labelFacebook = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHomeTown = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.richtextBoxPostContent = new System.Windows.Forms.RichTextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFacebook
            // 
            this.labelFacebook.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelFacebook.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFacebook.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.Color.White;
            this.labelFacebook.Location = new System.Drawing.Point(0, 0);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(1206, 137);
            this.labelFacebook.TabIndex = 1;
            this.labelFacebook.Text = "Facebook";
            this.labelFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(8, 140);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(238, 153);
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelBirthdate.Location = new System.Drawing.Point(12, 378);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(91, 18);
            this.labelBirthdate.TabIndex = 61;
            this.labelBirthdate.Text = "Birthdate:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(12, 313);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(110, 18);
            this.labelFirstName.TabIndex = 60;
            this.labelFirstName.Text = "First Name: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelLastName.Location = new System.Drawing.Point(12, 345);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(109, 18);
            this.labelLastName.TabIndex = 62;
            this.labelLastName.Text = "Last Name: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelEmail.Location = new System.Drawing.Point(12, 409);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 18);
            this.labelEmail.TabIndex = 63;
            this.labelEmail.Text = "Email:";
            // 
            // labelHomeTown
            // 
            this.labelHomeTown.AutoSize = true;
            this.labelHomeTown.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelHomeTown.Location = new System.Drawing.Point(12, 444);
            this.labelHomeTown.Name = "labelHomeTown";
            this.labelHomeTown.Size = new System.Drawing.Size(109, 18);
            this.labelHomeTown.TabIndex = 64;
            this.labelHomeTown.Text = "Home Town:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePosts);
            this.tabControl1.Controls.Add(this.tabPageAlbums);
            this.tabControl1.Location = new System.Drawing.Point(252, 140);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 514);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 65;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.flowLayoutPanelPosts);
            this.tabPagePosts.Controls.Add(this.buttonPost);
            this.tabPagePosts.Controls.Add(this.richtextBoxPostContent);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosts.Size = new System.Drawing.Size(807, 488);
            this.tabPagePosts.TabIndex = 0;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlbums.Size = new System.Drawing.Size(806, 488);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // listViewFriends
            // 
            this.listViewFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFriends.HideSelection = false;
            this.listViewFriends.Location = new System.Drawing.Point(1069, 162);
            this.listViewFriends.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(125, 485);
            this.listViewFriends.TabIndex = 66;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // richtextBoxPostContent
            // 
            this.richtextBoxPostContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextBoxPostContent.Location = new System.Drawing.Point(16, 393);
            this.richtextBoxPostContent.Name = "richtextBoxPostContent";
            this.richtextBoxPostContent.Size = new System.Drawing.Size(669, 86);
            this.richtextBoxPostContent.TabIndex = 0;
            this.richtextBoxPostContent.Text = "";
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Location = new System.Drawing.Point(691, 390);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(98, 89);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click_1);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(15, 574);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(197, 67);
            this.buttonLogout.TabIndex = 67;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(-4, 0);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(810, 387);
            this.flowLayoutPanelPosts.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 653);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listViewFriends);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelHomeTown);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelFacebook);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePosts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHomeTown;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.RichTextBox richtextBoxPostContent;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
    }
}