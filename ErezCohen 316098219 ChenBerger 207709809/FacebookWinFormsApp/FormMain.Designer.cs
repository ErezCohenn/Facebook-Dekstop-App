
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHomeTown = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshPosts = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPost = new System.Windows.Forms.Button();
            this.richtextBoxPostContent = new System.Windows.Forms.RichTextBox();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshAlbums = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshGroups = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshEvents = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageFriendsChart = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabPageEventsCalender = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            this.tabPageAlbums.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.tabPageFriendsChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabPageEventsCalender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFacebook
            // 
            this.labelFacebook.BackColor = System.Drawing.Color.RoyalBlue;
            this.labelFacebook.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFacebook.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacebook.ForeColor = System.Drawing.Color.White;
            this.labelFacebook.Location = new System.Drawing.Point(0, 0);
            this.labelFacebook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(1337, 169);
            this.labelFacebook.TabIndex = 1;
            this.labelFacebook.Text = "Facebook";
            this.labelFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(11, 172);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(317, 188);
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelBirthdate.Location = new System.Drawing.Point(16, 465);
            this.labelBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(115, 25);
            this.labelBirthdate.TabIndex = 61;
            this.labelBirthdate.Text = "Birthdate:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(16, 385);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(138, 25);
            this.labelFirstName.TabIndex = 60;
            this.labelFirstName.Text = "First Name: ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelLastName.Location = new System.Drawing.Point(16, 425);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(134, 25);
            this.labelLastName.TabIndex = 62;
            this.labelLastName.Text = "Last Name: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelEmail.Location = new System.Drawing.Point(16, 503);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(77, 25);
            this.labelEmail.TabIndex = 63;
            this.labelEmail.Text = "Email:";
            // 
            // labelHomeTown
            // 
            this.labelHomeTown.AutoSize = true;
            this.labelHomeTown.Font = new System.Drawing.Font("Verdana", 12F);
            this.labelHomeTown.Location = new System.Drawing.Point(16, 546);
            this.labelHomeTown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHomeTown.Name = "labelHomeTown";
            this.labelHomeTown.Size = new System.Drawing.Size(137, 25);
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
            this.tabControl1.Controls.Add(this.tabPageGroups);
            this.tabControl1.Controls.Add(this.tabPageEvents);
            this.tabControl1.Controls.Add(this.tabPageFriendsChart);
            this.tabControl1.Controls.Add(this.tabPageEventsCalender);
            this.tabControl1.Location = new System.Drawing.Point(336, 172);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 633);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 65;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.linkLabelRefreshPosts);
            this.tabPagePosts.Controls.Add(this.flowLayoutPanelPosts);
            this.tabPagePosts.Controls.Add(this.buttonPost);
            this.tabPagePosts.Controls.Add(this.richtextBoxPostContent);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 25);
            this.tabPagePosts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Size = new System.Drawing.Size(808, 604);
            this.tabPagePosts.TabIndex = 0;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshPosts
            // 
            this.linkLabelRefreshPosts.AutoSize = true;
            this.linkLabelRefreshPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshPosts.Location = new System.Drawing.Point(7, 4);
            this.linkLabelRefreshPosts.Name = "linkLabelRefreshPosts";
            this.linkLabelRefreshPosts.Size = new System.Drawing.Size(131, 25);
            this.linkLabelRefreshPosts.TabIndex = 3;
            this.linkLabelRefreshPosts.TabStop = true;
            this.linkLabelRefreshPosts.Text = "Refresh posts";
            this.linkLabelRefreshPosts.UseMnemonic = false;
            this.linkLabelRefreshPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshPosts_LinkClicked);
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(4, 33);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(1071, 443);
            this.flowLayoutPanelPosts.TabIndex = 2;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Location = new System.Drawing.Point(650, 480);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(131, 110);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click_1);
            // 
            // richtextBoxPostContent
            // 
            this.richtextBoxPostContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextBoxPostContent.Location = new System.Drawing.Point(21, 484);
            this.richtextBoxPostContent.Margin = new System.Windows.Forms.Padding(4);
            this.richtextBoxPostContent.Name = "richtextBoxPostContent";
            this.richtextBoxPostContent.Size = new System.Drawing.Size(620, 105);
            this.richtextBoxPostContent.TabIndex = 0;
            this.richtextBoxPostContent.Text = "";
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.linkLabelRefreshAlbums);
            this.tabPageAlbums.Controls.Add(this.flowLayoutPanelAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Size = new System.Drawing.Size(808, 604);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshAlbums
            // 
            this.linkLabelRefreshAlbums.AutoSize = true;
            this.linkLabelRefreshAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshAlbums.Location = new System.Drawing.Point(7, 4);
            this.linkLabelRefreshAlbums.Name = "linkLabelRefreshAlbums";
            this.linkLabelRefreshAlbums.Size = new System.Drawing.Size(147, 25);
            this.linkLabelRefreshAlbums.TabIndex = 4;
            this.linkLabelRefreshAlbums.TabStop = true;
            this.linkLabelRefreshAlbums.Text = "Refresh albums";
            this.linkLabelRefreshAlbums.UseMnemonic = false;
            this.linkLabelRefreshAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshAlbums_LinkClicked);
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(-4, 33);
            this.flowLayoutPanelAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(1079, 567);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.linkLabelRefreshGroups);
            this.tabPageGroups.Controls.Add(this.flowLayoutPanelGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(808, 604);
            this.tabPageGroups.TabIndex = 2;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshGroups
            // 
            this.linkLabelRefreshGroups.AutoSize = true;
            this.linkLabelRefreshGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshGroups.Location = new System.Drawing.Point(6, 3);
            this.linkLabelRefreshGroups.Name = "linkLabelRefreshGroups";
            this.linkLabelRefreshGroups.Size = new System.Drawing.Size(144, 25);
            this.linkLabelRefreshGroups.TabIndex = 5;
            this.linkLabelRefreshGroups.TabStop = true;
            this.linkLabelRefreshGroups.Text = "Refresh groups";
            this.linkLabelRefreshGroups.UseMnemonic = false;
            this.linkLabelRefreshGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshGroups_LinkClicked);
            // 
            // flowLayoutPanelGroups
            // 
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(1073, 570);
            this.flowLayoutPanelGroups.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.linkLabelRefreshEvents);
            this.tabPageEvents.Controls.Add(this.flowLayoutPanelEvents);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 25);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(808, 604);
            this.tabPageEvents.TabIndex = 3;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshEvents
            // 
            this.linkLabelRefreshEvents.AutoSize = true;
            this.linkLabelRefreshEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshEvents.Location = new System.Drawing.Point(6, 3);
            this.linkLabelRefreshEvents.Name = "linkLabelRefreshEvents";
            this.linkLabelRefreshEvents.Size = new System.Drawing.Size(142, 25);
            this.linkLabelRefreshEvents.TabIndex = 6;
            this.linkLabelRefreshEvents.TabStop = true;
            this.linkLabelRefreshEvents.Text = "Refresh events";
            this.linkLabelRefreshEvents.UseMnemonic = false;
            this.linkLabelRefreshEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshEvents_LinkClicked);
            // 
            // flowLayoutPanelEvents
            // 
            this.flowLayoutPanelEvents.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            this.flowLayoutPanelEvents.Size = new System.Drawing.Size(1073, 570);
            this.flowLayoutPanelEvents.TabIndex = 0;
            // 
            // tabPageFriendsChart
            // 
            this.tabPageFriendsChart.Controls.Add(this.chart);
            this.tabPageFriendsChart.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriendsChart.Name = "tabPageFriendsChart";
            this.tabPageFriendsChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriendsChart.Size = new System.Drawing.Size(808, 604);
            this.tabPageFriendsChart.TabIndex = 4;
            this.tabPageFriendsChart.Text = "Friends Chart";
            this.tabPageFriendsChart.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "FriendsCitiesChart";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(802, 598);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // listViewFriends
            // 
            this.listViewFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFriends.HideSelection = false;
            this.listViewFriends.Location = new System.Drawing.Point(1154, 199);
            this.listViewFriends.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(165, 596);
            this.listViewFriends.TabIndex = 66;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(20, 706);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(263, 82);
            this.buttonLogout.TabIndex = 67;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabPageEventsCalender
            // 
            this.tabPageEventsCalender.Controls.Add(this.listBoxEvents);
            this.tabPageEventsCalender.Controls.Add(this.monthCalendar1);
            this.tabPageEventsCalender.Location = new System.Drawing.Point(4, 25);
            this.tabPageEventsCalender.Name = "tabPageEventsCalender";
            this.tabPageEventsCalender.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventsCalender.Size = new System.Drawing.Size(808, 604);
            this.tabPageEventsCalender.TabIndex = 5;
            this.tabPageEventsCalender.Text = "Events calender";
            this.tabPageEventsCalender.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(38, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(420, 34);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(363, 452);
            this.listBoxEvents.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 804);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePosts.ResumeLayout(false);
            this.tabPagePosts.PerformLayout();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            this.tabPageEvents.ResumeLayout(false);
            this.tabPageEvents.PerformLayout();
            this.tabPageFriendsChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabPageEventsCalender.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvents;
        private System.Windows.Forms.LinkLabel linkLabelRefreshPosts;
        private System.Windows.Forms.LinkLabel linkLabelRefreshAlbums;
        private System.Windows.Forms.LinkLabel linkLabelRefreshGroups;
        private System.Windows.Forms.LinkLabel linkLabelRefreshEvents;
        private System.Windows.Forms.TabPage tabPageFriendsChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabPage tabPageEventsCalender;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}