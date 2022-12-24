namespace BasicFacebookFeatures
{
    public partial class FormFacebookApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabelPages = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelPages = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.checkBoxFilterDates = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEventFilter = new System.Windows.Forms.DateTimePicker();
            this.linkLabelRefreshEvents = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshGroups = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshAlbums = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshPosts = new System.Windows.Forms.LinkLabel();
            this.buttonPost = new System.Windows.Forms.Button();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.richtextBoxPostContent = new System.Windows.Forms.RichTextBox();
            this.tabPageFriendsChart = new System.Windows.Forms.TabPage();
            this.linkLabelRefreshChart = new System.Windows.Forms.LinkLabel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.firstNameLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.localeLabel1 = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            this.tabPageAlbums.SuspendLayout();
            this.tabPagePosts.SuspendLayout();
            this.tabPageFriendsChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            aboutLabel.Location = new System.Drawing.Point(11, 878);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(70, 25);
            aboutLabel.TabIndex = 68;
            aboutLabel.Text = "About:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            birthdayLabel.Location = new System.Drawing.Point(9, 670);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(89, 25);
            birthdayLabel.TabIndex = 70;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            emailLabel.Location = new System.Drawing.Point(9, 745);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(66, 25);
            emailLabel.TabIndex = 72;
            emailLabel.Text = "Email:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            lastNameLabel.Location = new System.Drawing.Point(9, 609);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(112, 25);
            lastNameLabel.TabIndex = 78;
            lastNameLabel.Text = "Last Name:";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            localeLabel.Location = new System.Drawing.Point(9, 808);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(76, 25);
            localeLabel.TabIndex = 80;
            localeLabel.Text = "Locale:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            firstNameLabel.Location = new System.Drawing.Point(12, 548);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(112, 25);
            firstNameLabel.TabIndex = 74;
            firstNameLabel.Text = "First Name:";
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
            this.labelFacebook.Size = new System.Drawing.Size(1956, 211);
            this.labelFacebook.TabIndex = 1;
            this.labelFacebook.Text = "Facebook";
            this.labelFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewFriends
            // 
            this.listViewFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFriends.HideSelection = false;
            this.listViewFriends.Location = new System.Drawing.Point(2548, 294);
            this.listViewFriends.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(258, 1770);
            this.listViewFriends.TabIndex = 66;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Location = new System.Drawing.Point(31, 1931);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(411, 128);
            this.buttonLogout.TabIndex = 67;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabelPages);
            this.tabPage1.Controls.Add(this.flowLayoutPanelPages);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2002, 1762);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Pages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabelPages
            // 
            this.linkLabelPages.AutoSize = true;
            this.linkLabelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelPages.Location = new System.Drawing.Point(6, 3);
            this.linkLabelPages.Name = "linkLabelPages";
            this.linkLabelPages.Size = new System.Drawing.Size(138, 25);
            this.linkLabelPages.TabIndex = 7;
            this.linkLabelPages.TabStop = true;
            this.linkLabelPages.Text = "Refresh pages";
            this.linkLabelPages.UseMnemonic = false;
            this.linkLabelPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPages_LinkClicked);
            // 
            // flowLayoutPanelPages
            // 
            this.flowLayoutPanelPages.AutoScroll = true;
            this.flowLayoutPanelPages.Location = new System.Drawing.Point(6, 31);
            this.flowLayoutPanelPages.Name = "flowLayoutPanelPages";
            this.flowLayoutPanelPages.Size = new System.Drawing.Size(1011, 678);
            this.flowLayoutPanelPages.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.AutoScroll = true;
            this.tabPageEvents.Controls.Add(this.label1);
            this.tabPageEvents.Controls.Add(this.dateTimePickerEventFilter);
            this.tabPageEvents.Controls.Add(this.checkBoxFilterDates);
            this.tabPageEvents.Controls.Add(this.linkLabelRefreshEvents);
            this.tabPageEvents.Controls.Add(this.flowLayoutPanelEvents);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 25);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(2002, 1762);
            this.tabPageEvents.TabIndex = 3;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterDates
            // 
            this.checkBoxFilterDates.AutoSize = true;
            this.checkBoxFilterDates.Location = new System.Drawing.Point(303, 58);
            this.checkBoxFilterDates.Name = "checkBoxFilterDates";
            this.checkBoxFilterDates.Size = new System.Drawing.Size(115, 21);
            this.checkBoxFilterDates.TabIndex = 8;
            this.checkBoxFilterDates.Text = "Filter By Date";
            this.checkBoxFilterDates.UseVisualStyleBackColor = true;
            this.checkBoxFilterDates.CheckedChanged += new System.EventHandler(this.checkBoxFilterDates_CheckedChanged);
            // 
            // dateTimePickerEventFilter
            // 
            this.dateTimePickerEventFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEventFilter.Enabled = false;
            this.dateTimePickerEventFilter.Location = new System.Drawing.Point(424, 58);
            this.dateTimePickerEventFilter.Name = "dateTimePickerEventFilter";
            this.dateTimePickerEventFilter.Size = new System.Drawing.Size(386, 22);
            this.dateTimePickerEventFilter.TabIndex = 7;
            this.dateTimePickerEventFilter.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // linkLabelRefreshEvents
            // 
            this.linkLabelRefreshEvents.AutoSize = true;
            this.linkLabelRefreshEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshEvents.Location = new System.Drawing.Point(20, 10);
            this.linkLabelRefreshEvents.Name = "linkLabelRefreshEvents";
            this.linkLabelRefreshEvents.Size = new System.Drawing.Size(142, 25);
            this.linkLabelRefreshEvents.TabIndex = 6;
            this.linkLabelRefreshEvents.TabStop = true;
            this.linkLabelRefreshEvents.Text = "Refresh events";
            this.linkLabelRefreshEvents.UseMnemonic = false;
            this.linkLabelRefreshEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshEvents_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter events by specific date:";
            // 
            // flowLayoutPanelEvents
            // 
            this.flowLayoutPanelEvents.AutoScroll = true;
            this.flowLayoutPanelEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelEvents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEvents.Location = new System.Drawing.Point(4, 113);
            this.flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            this.flowLayoutPanelEvents.Size = new System.Drawing.Size(1269, 778);
            this.flowLayoutPanelEvents.TabIndex = 0;
            this.flowLayoutPanelEvents.WrapContents = false;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.linkLabelRefreshGroups);
            this.tabPageGroups.Controls.Add(this.flowLayoutPanelGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(2002, 1762);
            this.tabPageGroups.TabIndex = 2;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshGroups
            // 
            this.linkLabelRefreshGroups.AutoSize = true;
            this.linkLabelRefreshGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshGroups.Location = new System.Drawing.Point(9, 5);
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
            this.flowLayoutPanelGroups.AutoScroll = true;
            this.flowLayoutPanelGroups.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(16, 44);
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(1574, 1089);
            this.flowLayoutPanelGroups.TabIndex = 0;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.AutoScroll = true;
            this.tabPageAlbums.Controls.Add(this.linkLabelRefreshAlbums);
            this.tabPageAlbums.Controls.Add(this.flowLayoutPanelAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Size = new System.Drawing.Size(2002, 1762);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshAlbums
            // 
            this.linkLabelRefreshAlbums.AutoSize = true;
            this.linkLabelRefreshAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshAlbums.Location = new System.Drawing.Point(18, 10);
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
            this.flowLayoutPanelAlbums.AutoSize = true;
            this.flowLayoutPanelAlbums.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAlbums.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(-11, 81);
            this.flowLayoutPanelAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            this.flowLayoutPanelAlbums.WrapContents = false;
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.AutoScroll = true;
            this.tabPagePosts.Controls.Add(this.linkLabelRefreshPosts);
            this.tabPagePosts.Controls.Add(this.buttonPost);
            this.tabPagePosts.Controls.Add(this.flowLayoutPanelPosts);
            this.tabPagePosts.Controls.Add(this.richtextBoxPostContent);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 25);
            this.tabPagePosts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Size = new System.Drawing.Size(2002, 1762);
            this.tabPagePosts.TabIndex = 0;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshPosts
            // 
            this.linkLabelRefreshPosts.AutoSize = true;
            this.linkLabelRefreshPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshPosts.Location = new System.Drawing.Point(18, 10);
            this.linkLabelRefreshPosts.Name = "linkLabelRefreshPosts";
            this.linkLabelRefreshPosts.Size = new System.Drawing.Size(131, 25);
            this.linkLabelRefreshPosts.TabIndex = 3;
            this.linkLabelRefreshPosts.TabStop = true;
            this.linkLabelRefreshPosts.Text = "Refresh posts";
            this.linkLabelRefreshPosts.UseMnemonic = false;
            this.linkLabelRefreshPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshPosts_LinkClicked);
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Location = new System.Drawing.Point(2114, 1480);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(255, 216);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(26, 41);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(1214, 711);
            this.flowLayoutPanelPosts.TabIndex = 2;
            // 
            // richtextBoxPostContent
            // 
            this.richtextBoxPostContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richtextBoxPostContent.Location = new System.Drawing.Point(51, 1493);
            this.richtextBoxPostContent.Margin = new System.Windows.Forms.Padding(4);
            this.richtextBoxPostContent.Name = "richtextBoxPostContent";
            this.richtextBoxPostContent.Size = new System.Drawing.Size(3983, 205);
            this.richtextBoxPostContent.TabIndex = 0;
            this.richtextBoxPostContent.Text = string.Empty;
            // 
            // tabPageFriendsChart
            // 
            this.tabPageFriendsChart.Controls.Add(this.linkLabelRefreshChart);
            this.tabPageFriendsChart.Controls.Add(this.chart);
            this.tabPageFriendsChart.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriendsChart.Name = "tabPageFriendsChart";
            this.tabPageFriendsChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriendsChart.Size = new System.Drawing.Size(2002, 1762);
            this.tabPageFriendsChart.TabIndex = 4;
            this.tabPageFriendsChart.Text = "Cities Distribution";
            this.tabPageFriendsChart.UseVisualStyleBackColor = true;
            // 
            // linkLabelRefreshChart
            // 
            this.linkLabelRefreshChart.AutoSize = true;
            this.linkLabelRefreshChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabelRefreshChart.Location = new System.Drawing.Point(4, 39);
            this.linkLabelRefreshChart.Name = "linkLabelRefreshChart";
            this.linkLabelRefreshChart.Size = new System.Drawing.Size(170, 25);
            this.linkLabelRefreshChart.TabIndex = 7;
            this.linkLabelRefreshChart.TabStop = true;
            this.linkLabelRefreshChart.Text = "Refresh chart data";
            this.linkLabelRefreshChart.UseMnemonic = false;
            this.linkLabelRefreshChart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefreshChart_LinkClicked);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "FriendsCitiesChart";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1996, 1756);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageFriendsChart);
            this.tabControl1.Controls.Add(this.tabPagePosts);
            this.tabControl1.Controls.Add(this.tabPageAlbums);
            this.tabControl1.Controls.Add(this.tabPageGroups);
            this.tabControl1.Controls.Add(this.tabPageEvents);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(525, 295);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2010, 1791);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 65;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.aboutLabel1.Location = new System.Drawing.Point(13, 921);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(458, 118);
            this.aboutLabel1.TabIndex = 69;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayLabel1.Location = new System.Drawing.Point(162, 667);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(292, 28);
            this.birthdayLabel1.TabIndex = 71;
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailLabel1.Location = new System.Drawing.Point(162, 745);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(356, 25);
            this.emailLabel1.TabIndex = 73;
            // 
            // firstNameLabel1
            // 
            this.firstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstNameLabel1.Location = new System.Drawing.Point(162, 552);
            this.firstNameLabel1.Name = "firstNameLabel1";
            this.firstNameLabel1.Size = new System.Drawing.Size(174, 25);
            this.firstNameLabel1.TabIndex = 75;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(25, 269);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(484, 243);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 77;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastNameLabel1.Location = new System.Drawing.Point(162, 613);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(215, 26);
            this.lastNameLabel1.TabIndex = 79;
            // 
            // localeLabel1
            // 
            this.localeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.localeLabel1.Location = new System.Drawing.Point(162, 812);
            this.localeLabel1.Name = "localeLabel1";
            this.localeLabel1.Size = new System.Drawing.Size(160, 21);
            this.localeLabel1.TabIndex = 81;
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1956, 1202);
            this.Controls.Add(aboutLabel);
            this.Controls.Add(this.aboutLabel1);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailLabel1);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameLabel1);
            this.Controls.Add(this.imageNormalPictureBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameLabel1);
            this.Controls.Add(localeLabel);
            this.Controls.Add(this.localeLabel1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listViewFriends);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelFacebook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFacebookApp";
            this.Text = "Facebook App";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageEvents.ResumeLayout(false);
            this.tabPageEvents.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            this.tabPagePosts.ResumeLayout(false);
            this.tabPagePosts.PerformLayout();
            this.tabPageFriendsChart.ResumeLayout(false);
            this.tabPageFriendsChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        
        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPages;
        private System.Windows.Forms.LinkLabel linkLabelPages;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventFilter;
        private System.Windows.Forms.LinkLabel linkLabelRefreshEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.LinkLabel linkLabelRefreshGroups;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.LinkLabel linkLabelRefreshAlbums;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.LinkLabel linkLabelRefreshPosts;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.RichTextBox richtextBoxPostContent;
        private System.Windows.Forms.TabPage tabPageFriendsChart;
        private System.Windows.Forms.LinkLabel linkLabelRefreshChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox checkBoxFilterDates;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label firstNameLabel1;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label localeLabel1;
    }
}