﻿using BasicFacebookFeatures.UserControlItems;
using DTO;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFacebookApp : Form
    {
        private const string k_SeriesCityFriendsName = "FriendsCitiesChart";
        private const string k_NoDataToShowMessage = "No items to retrieve";
        private readonly LogicManager r_LogicManager;
        private ImageList m_FriendsImagesList;
        private bool m_IsLogoutButtonClicked;

        public bool IsLogoutButtonClicked { get => m_IsLogoutButtonClicked; }

        public FormFacebookApp()
        {
            InitializeComponent();
            r_LogicManager = LogicManager.Instance;
            m_IsLogoutButtonClicked = false;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchUserData();
        }
        private void fetchUserData()
        {
            new Thread(fetchFriendsList).Start();
            new Thread(fetchPosts).Start();
            new Thread(fetchAlbums).Start();
            new Thread(fetchGroups).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchFriendsCitiesChart).Start();
            new Thread(fetchPages).Start();
            fetchProfileData();

        }

        private void fetchPages()
        {
            FacebookObjectCollection<Page> pages = r_LogicManager.FetchPages();
            ListItem pageItem = null;


            flowLayoutPanelPages.Invoke(new Action(() => flowLayoutPanelPages.Controls.Clear()));
            try
            {
                foreach (Page page in pages)
                {
                    pageItem = ListItemFactoryMethod.CreateListItem(page);
                    flowLayoutPanelPages.Invoke(new Action(() => flowLayoutPanelPages.Controls.Add(pageItem)));
                }
            }
            catch (System.ArgumentException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelPages.Controls.Count == 0)
            {
                flowLayoutPanelPages.Invoke(new Action(() => flowLayoutPanelPages.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
                })));
            }
        }

        private void fetchFriendsCitiesChart()
        {
            Dictionary<string, int> friendsCitiesList = r_LogicManager.FetchFriendsCities();

            chart.Invoke(new Action(() => chart.Series.FindByName(k_SeriesCityFriendsName).Points.Clear()));
            try
            {
                foreach (KeyValuePair<string, int> city in friendsCitiesList)
                {
                    chart.Invoke(new Action(() => chart.Series.FindByName(k_SeriesCityFriendsName).Points.AddXY(city.Key, city.Value.ToString())));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (chart.Series.FindByName(k_SeriesCityFriendsName).Points.Count == 0)
            {
                chart.Invoke(new Action(() => Text = k_NoDataToShowMessage));
            }
        }

        private void fetchAlbums()
        {
            FacebookObjectCollection<Album> albums = r_LogicManager.FetchAlbums();
            ListItem albumItem = null;

            flowLayoutPanelAlbums.Invoke(new Action(() => flowLayoutPanelAlbums.Controls.Clear()));
            try
            {
                foreach (Album album in albums)
                {
                    albumItem = ListItemFactoryMethod.CreateListItem(album);
                    flowLayoutPanelAlbums.Invoke(new Action(() => flowLayoutPanelAlbums.Controls.Add(albumItem)));

                }
            }
            catch (System.ArgumentException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelAlbums.Controls.Count == 0)
            {
                flowLayoutPanelAlbums.Invoke(new Action(() => flowLayoutPanelAlbums.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
                })));
            }
        }

        private void fetchPosts()
        {

            FacebookObjectCollection<Post> posts = r_LogicManager.FetchPosts();
            ListItem postItem = null;

            flowLayoutPanelPosts.Invoke(new Action(() => flowLayoutPanelPosts.Controls.Clear()));
            try
            {
                foreach (Post post in posts)
                {
                    postItem = ListItemFactoryMethod.CreateListItem(post);
                    flowLayoutPanelPosts.Invoke(new Action(() => flowLayoutPanelPosts.Controls.Add(postItem)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelPosts.Controls.Count == 0)
            {
                flowLayoutPanelPosts.Invoke(new Action(() => flowLayoutPanelPosts.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
                })));
            }
        }

        private void fetchProfileData()
        {
            userBindingSource.DataSource = r_LogicManager.CurrentUser;
        }

        private void fetchFriendsList()
        {
            FriendsListDTO friendsListDTO;
            int friendIndex = 0;
            listViewFriends.Invoke(new Action(() => listViewFriends.Items.Clear()));
            listViewFriends.Invoke(new Action(() => listViewFriends.View = View.Details));
            listViewFriends.Invoke(new Action(() => listViewFriends.Columns.Add("Friends list:", 200)));
            m_FriendsImagesList = new ImageList();
            m_FriendsImagesList.ImageSize = new Size(50, 50);

            try
            {
                friendsListDTO = r_LogicManager.FetchFriendsList();
                foreach (KeyValuePair<string, Image> friend in friendsListDTO.FriendsList)
                {
                    listViewFriends.Invoke(new Action(() => listViewFriends.Items.Add(friend.Key, friendIndex++)));
                    m_FriendsImagesList.Images.Add(friend.Value);
                }

                listViewFriends.Invoke(new Action(() => listViewFriends.SmallImageList = m_FriendsImagesList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to load friends list");
            }
        }

        private void fetchGroups()
        {

            FacebookObjectCollection<Group> groups = r_LogicManager.FetchGroups();
            ListItem groupItem = null;

            flowLayoutPanelGroups.Invoke(new Action(() => flowLayoutPanelGroups.Controls.Clear()));
            try
            {
                foreach (Group group in groups)
                {
                    groupItem = ListItemFactoryMethod.CreateListItem(group);
                    flowLayoutPanelGroups.Invoke(new Action(() => flowLayoutPanelGroups.Controls.Add(groupItem)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelGroups.Controls.Count == 0)
            {
                flowLayoutPanelGroups.Invoke(new Action(() => flowLayoutPanelGroups.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
                })));
            }
        }

        private void fetchEvents()
        {
            showEvents(r_LogicManager.FetchEvents());
        }

        private void showEvents(FacebookObjectCollection<Event> events)
        {
            ListItem eventItem = null;

            flowLayoutPanelEvents.Invoke(new Action(() => flowLayoutPanelEvents.Controls.Clear()));
            try
            {
                foreach (Event eventToAdd in events)
                {

                    eventItem = ListItemFactoryMethod.CreateListItem(eventToAdd);
                    flowLayoutPanelEvents.Invoke(new Action(() => flowLayoutPanelEvents.Controls.Add(eventItem)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelEvents.Controls.Count == 0)
            {
                flowLayoutPanelEvents.Invoke(new Action(() => flowLayoutPanelEvents.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
                })));
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => r_LogicManager.AddPost(richtextBoxPostContent.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_LogicManager.Logout();
            m_IsLogoutButtonClicked = true;
            this.Close();
        }

        private void linkLabelRefreshPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void linkLabelRefreshAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void linkLabelRefreshGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void linkLabelRefreshEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void linkLabelRefreshChart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchFriendsCitiesChart).Start();
        }

        private void linkLabelPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchPages).Start();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            new Thread(fetchEventsByDate).Start();
        }

        private void fetchEventsByDate()
        {
            showEvents(r_LogicManager.FetchEventsByDate(dateTimePickerEventFilter.Value.Date));
        }

        private void checkBoxFilterDates_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEventFilter.Enabled = checkBoxFilterDates.Checked;
        }
    }
}
