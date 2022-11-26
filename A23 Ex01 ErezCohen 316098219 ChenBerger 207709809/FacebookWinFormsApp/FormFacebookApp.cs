using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using FacebookLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormFacebookApp : Form
    {
        private const string k_SeriesCityFriendsName = "FriendsCitiesChart";
        private const string k_NoDataToShowMessage = "No items to retrieve";
        private LogicManager m_LogicManager;
        private ImageList m_FriendsImagesList;
        private bool m_IsLogoutButtonClicked;

        public bool IsLogoutButtonClicked { get => m_IsLogoutButtonClicked; }

        public FormFacebookApp(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_LogicManager = i_LogicManager;
            m_IsLogoutButtonClicked = false;
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
            fetchPages();
        }

        private void fetchPages()
        {
            FacebookObjectCollection<Page> pages = m_LogicManager.FetchPages();
            PageItem pageItem = null;

            flowLayoutPanelPages.Controls.Clear();
            try
            {
                foreach (Page page in pages)
                {
                    pageItem = new PageItem(page);
                    flowLayoutPanelPages.Controls.Add(pageItem);
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
                flowLayoutPanelPages.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
                });
            }
        }

        private void fetchFriendsCitiesChart()
        {
            Dictionary<string, int> friendsCitiesList = m_LogicManager.FetchFriendsCities();

            chart.Series.FindByName(k_SeriesCityFriendsName).Points.Clear();
            try
            {
                foreach (KeyValuePair<string, int> city in friendsCitiesList)
                {
                    chart.Series.FindByName(k_SeriesCityFriendsName).Points.AddXY(city.Key, city.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (chart.Series.FindByName(k_SeriesCityFriendsName).Points.Count == 0)
            {
                chart.Text = k_NoDataToShowMessage;
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
            catch (System.ArgumentException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelAlbums.Controls.Count == 0)
            {
                flowLayoutPanelAlbums.Controls.Add(new Label()
                {
                    Text = k_NoDataToShowMessage
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
                    Text = k_NoDataToShowMessage
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
                    Text = k_NoDataToShowMessage
                });
            }
        }

        private void fetchEvents()
        {
            showEvents(m_LogicManager.FetchEvents());
        }

        private void showEvents(FacebookObjectCollection<Event> events)
        {
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
                    Text = k_NoDataToShowMessage
                });
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                m_LogicManager.AddPost(richtextBoxPostContent.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

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

        private void linkLabelRefreshChart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriendsCitiesChart();
        }

        private void linkLabelPages_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchPages();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            showEvents(m_LogicManager.FetchEventsByDate(dateTimePickerEventFilter.Value.Date));
        }

        private void checkBoxFilterDates_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEventFilter.Enabled = checkBoxFilterDates.Checked;
        }
    }
}
