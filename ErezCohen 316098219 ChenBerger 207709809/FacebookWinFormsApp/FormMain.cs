using DTO;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private LogicManager m_LogicManager;
        private ImageList m_FriendsImagesList;
        private bool m_IsLogoutButtonClicked = false;

        public bool IsLogoutButtonClicked { get => m_IsLogoutButtonClicked; }

        public FormMain(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_LogicManager = i_LogicManager;
            fetchUserData();

        }

        private void fetchUserData()
        {
            fetchFriendsList();
            fetchImageProfile();
            fetchProfileData();
            fetchPosts();
            fetchAlbums();
            fetchGroups();
            fetchEvents();
            fetchFriendsCitiesChart();
        }

        private void fetchFriendsCitiesChart()
        {
            Dictionary<City, int> friendsCitiesList = m_LogicManager.FetchFriendsCities();

            chart.Series.Clear();
            try
            {
                foreach (KeyValuePair<City, int> city in friendsCitiesList)
                {
                    chart.Series["FriendsCitiesChart"].Points.AddXY(city.Key.ToString(), city.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchAlbums()
        {
            FacebookObjectCollection<Album> albums = m_LogicManager.FetchAlbums();
            AlbumItem albumItem = null;

            flowLayoutPanelAlbums.Controls.Clear();
            try
            {
                foreach (Album album in albums)
                {
                    albumItem = new AlbumItem(album);
                    flowLayoutPanelAlbums.Controls.Add(albumItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelAlbums.Controls.Count == 0)
            {
                flowLayoutPanelAlbums.Controls.Add(new Label()
                {
                    Text = "No items to retrieve"
                });
            }
        }

        private void fetchPosts()
        {
            FacebookObjectCollection<Post> posts = m_LogicManager.FetchPosts();
            PostItem postItem = null;

            flowLayoutPanelPosts.Controls.Clear();
            try
            {
                foreach (Post post in posts)
                {
                    postItem = new PostItem(post);
                    flowLayoutPanelPosts.Controls.Add(postItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelPosts.Controls.Count == 0)
            {
                flowLayoutPanelPosts.Controls.Add(new Label()
                {
                    Text = "No items to retrieve"
                });
            }
        }

        private void fetchProfileData()
        {
            ProfileDataDTO profileDataDTO = m_LogicManager.FetchProfileData();
            City userCity = profileDataDTO.HomeTown;
            Location userLocation = null;

            try
            {
                this.labelFirstName.Text = string.Format("First Name: {0}", profileDataDTO.FirstName);
                this.labelLastName.Text = string.Format("Last Name: {0}", profileDataDTO.LastName);
                this.labelEmail.Text = string.Format("Email: {0}", profileDataDTO.Email);
                this.labelBirthdate.Text = string.Format("Birthday: {0}", profileDataDTO.Birthday);
                this.labelFacebook.Text = string.Format("{0}book", profileDataDTO.FirstName);
                if (userCity != null)
                {
                    userLocation = userCity.Location;
                    this.labelHomeTown.Text = string.Format("{0}, {1}, {2}", userLocation.Country, userLocation.City, userLocation.Street);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchImageProfile()
        {
            pictureBoxProfile.LoadAsync(m_LogicManager.FetchUserProfileImageUrl());
        }

        private void fetchFriendsList()
        {
            FriendsListDTO friendsListDTO;
            int friendIndex = 0;

            listViewFriends.Items.Clear();
            listViewFriends.View = View.Details;
            listViewFriends.Columns.Add("Friends list:", 200);
            m_FriendsImagesList = new ImageList();
            m_FriendsImagesList.ImageSize = new Size(50, 50);

            try
            {
                friendsListDTO = m_LogicManager.FetchFriendsList();
                foreach (KeyValuePair<string, Image> friend in friendsListDTO.FriendsList)
                {
                    listViewFriends.Items.Add(friend.Key, friendIndex++);
                    m_FriendsImagesList.Images.Add(friend.Value);
                }

                listViewFriends.SmallImageList = m_FriendsImagesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to load friends list");
            }
        }

        private void fetchGroups()
        {
            FacebookObjectCollection<Group> groups = m_LogicManager.FetchGroups();
            GroupItem groupItem = null;

            flowLayoutPanelGroups.Controls.Clear();
            try
            {
                foreach (Group group in groups)
                {
                    groupItem = new GroupItem(group);
                    flowLayoutPanelGroups.Controls.Add(groupItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelGroups.Controls.Count == 0)
            {
                flowLayoutPanelGroups.Controls.Add(new Label()
                {
                    Text = "No items to retrieve"
                });
            }
        }

        private void fetchEvents()
        {
            FacebookObjectCollection<Event> events = m_LogicManager.FetchEvents();
            EventItem eventItem = null;

            flowLayoutPanelEvents.Controls.Clear();
            try
            {
                foreach (Event eventToAdd in events)
                {
                    eventItem = new EventItem(eventToAdd);
                    flowLayoutPanelEvents.Controls.Add(eventItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelEvents.Controls.Count == 0)
            {
                flowLayoutPanelEvents.Controls.Add(new Label()
                {
                    Text = "No items to retrieve"
                });
            }
        }

        private void buttonPost_Click_1(object sender, EventArgs e)
        {
            m_LogicManager.AddPost(richtextBoxPostContent.Text);
        }

        //private void fetchLikedPages()
        //{
        //    listBoxPages.Items.Clear();
        //    listBoxPages.DisplayMember = "Name";
        //    
        //    try
        //    {
        //        FacebookObjectCollection<Page> pages = m_LogicManager.fetchLikedPages();
        //        foreach (Page page in pages)
        //        {
        //            listBoxPages.Items.Add(page);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //
        //    if (listBoxPages.Items.Count == 0)
        //    {
        //        MessageBox.Show("No liked pages to retrieve :(");
        //    }
        //}
        //
        //private void fetchFavoriteTeams()
        //{
        //
        //    try
        //    {
        //        listBoxFavoriteTeams.Items.Clear();
        //        listBoxFavoriteTeams.DisplayMember = "Name";
        //        Page[] favoriteTeams = m_LogicManager.FetchFavoriteTeams();
        //        foreach (Page team in favoriteTeams)
        //        {
        //            listBoxFavoriteTeams.Items.Add(team);
        //        }
        //
        //        if (listBoxFavoriteTeams.Items.Count == 0)
        //        {
        //            MessageBox.Show("No teams to retrieve :(");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //
        //    if (listBoxFavoriteTeams.Items.Count == 0)
        //    {
        //        MessageBox.Show("No favorite teams to retrieve :(");
        //    }
        //}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogicManager.Logout();
            m_IsLogoutButtonClicked = true;
            this.Close();
        }

        private void linkLabelRefreshPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPosts();
        }

        private void linkLabelRefreshAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchAlbums();
        }

        private void linkLabelRefreshGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchGroups();
        }

        private void linkLabelRefreshEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchEvents();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            EventItem eventItem = null;

            fetchEvents();
            foreach (Control control in flowLayoutPanelEvents.Controls)
            {
                if (control is EventItem)
                {
                    eventItem = control as EventItem;
                    listBoxEvents.Items.Add(eventItem);
                }
            }

            if (listBoxEvents.Items.Count == 0)
            {
                listBoxEvents.Items.Add("No events in this date");
            }
        }
    }
}
