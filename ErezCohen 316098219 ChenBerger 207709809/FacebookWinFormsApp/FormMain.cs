using DTO;
using FacebookLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FacebookApp : Form
    {
        private LogicManager m_LogicManager;
        private ImageList m_FriendsImagesList;
        private bool m_IsLogoutButtonClicked = false;
        private const string c_SeriesCityFriendsName = "FriendsCitiesChart";

        public bool IsLogoutButtonClicked { get => m_IsLogoutButtonClicked; }

        public FacebookApp(LogicManager i_LogicManager)
        {
            InitializeComponent();
            m_LogicManager = i_LogicManager;
            //new DummyFactory();
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
            catch (System.ArgumentException ex) { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (flowLayoutPanelPages.Controls.Count == 0)
            {
                flowLayoutPanelPages.Controls.Add(new Label()
                {
                    Text = "No items to retrieve"
                });
            }
        }

        private void fetchFriendsCitiesChart()
        {
            Dictionary<string, int> friendsCitiesList = m_LogicManager.FetchFriendsCities();
            //Dictionary<string, int> friendsCitiesList = DummyFactory.FriendsCities;

            chart.Series.FindByName(c_SeriesCityFriendsName).Points.Clear();
            try
            {
                foreach (KeyValuePair<string, int> city in friendsCitiesList)
                {
                    chart.Series.FindByName(c_SeriesCityFriendsName).Points.AddXY(city.Key, city.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (chart.Series.FindByName(c_SeriesCityFriendsName).Points.Count == 0)
            {
                chart.Text = "No items to retrieve";
            }
        }

        private void fetchAlbums()
        {
            FacebookObjectCollection<Album> albums = m_LogicManager.FetchAlbums();
            AlbumItem albumItem = null;
            //List<AlbumItem> albums = DummyFactory.AlbumItems;

            flowLayoutPanelAlbums.Controls.Clear();
            try
            {
                foreach (Album album in albums)
                {
                    albumItem = new AlbumItem(album);
                    flowLayoutPanelAlbums.Controls.Add(albumItem);
                }
            }
            catch (System.ArgumentException ex) { }
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
            //List<PostItem> posts = DummyFactory.PostItem;

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
                //friendsListDTO = DummyFactory.FriendsListDTO;
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
            //List<GroupItem> groups = DummyFactory.GroupItem;
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
                    Text = "No items to retrieve"
                });
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            m_LogicManager.AddPost(richtextBoxPostContent.Text);
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
