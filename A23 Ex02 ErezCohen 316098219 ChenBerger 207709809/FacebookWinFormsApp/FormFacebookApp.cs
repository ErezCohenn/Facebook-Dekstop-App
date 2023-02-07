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
        private readonly FacebookFeaturesFacade r_FacebookFeaturesFacade;
        private ImageList m_FriendsImagesList;
        private bool m_IsLogoutButtonClicked;

        public bool IsLogoutButtonClicked { get => m_IsLogoutButtonClicked; }

        public FormFacebookApp()
        {
            InitializeComponent();
            m_IsLogoutButtonClicked = false;
            r_FacebookFeaturesFacade = new FacebookFeaturesFacade();
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
            FacebookObjectCollection<Page> pages = r_FacebookFeaturesFacade.FetchPages();
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
            Dictionary<string, int> friendsCitiesList = r_FacebookFeaturesFacade.FetchFriendsCities();

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
        }

        private void fetchAlbums()
        {
            FacebookObjectCollection<Album> albums = r_FacebookFeaturesFacade.FetchAlbums();
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
            FacebookObjectCollection<Post> posts = r_FacebookFeaturesFacade.FetchPosts();
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
            userBindingSource.DataSource = r_FacebookFeaturesFacade.GetCurrentUser();
        }

        private void fetchFriendsList()
        {
            listViewFriends.Invoke(new Action(() => listViewFriends.Items.Clear()));
            listViewFriends.Invoke(new Action(() => listViewFriends.View = View.Details));
            listViewFriends.Invoke(new Action(() => listViewFriends.Columns.Add("Friends list:", 200)));
            setFriendsListView(r_FacebookFeaturesFacade.FetchFriendsList());
        }

        private void setFriendsListView(FriendsListDTO i_Friends)
        {
            int friendIndex = 0;

            m_FriendsImagesList = new ImageList();
            m_FriendsImagesList.ImageSize = new Size(50, 50);
            try
            {
                foreach (KeyValuePair<string, Image> friend in i_Friends)
                {
                    listViewFriends.Invoke(new Action(() => listViewFriends.Items.Add(friend.Key, friendIndex++)));
                    m_FriendsImagesList.Images.Add(Image.FromFile(Resources.FacebookDefultPicturePath));
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
            FacebookObjectCollection<Group> groups = r_FacebookFeaturesFacade.FetchGroups();
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
            showEvents(r_FacebookFeaturesFacade.FetchEvents());
        }

        private void showEvents(FacebookObjectCollection<Event> i_Events)
        {
            ListItem eventItem = null;

            flowLayoutPanelEvents.Invoke(new Action(() => flowLayoutPanelEvents.Controls.Clear()));
            try
            {
                foreach (Event eventToAdd in i_Events)
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_FacebookFeaturesFacade.Logout();
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
            showEvents(r_FacebookFeaturesFacade.FetchEventsByDate(dateTimePickerEventFilter.Value.Date));
        }

        private void checkBoxFilterDates_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerEventFilter.Enabled = checkBoxFilterDates.Checked;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string postContent = richtextBoxPostContent.Text;
            try
            {
                new Thread(() => r_FacebookFeaturesFacade.AddPost(postContent)).Start();
                r_FacebookFeaturesFacade.PostCollectionChanged += FacebookFeaturesFacade_PostCollectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FacebookFeaturesFacade_PostCollectionChanged(FacebookObjectCollection<Post> i_PostCollection)
        {
            new Thread(fetchPosts).Start();
            r_FacebookFeaturesFacade.PostCollectionChanged -= FacebookFeaturesFacade_PostCollectionChanged;
        }

        private void buttonSortFriends_Click(object sender, EventArgs e)
        {
            int sortMethod = FriendsSortMethodComboBox.SelectedIndex;
            try
            {
                if (FriendsSortMethodComboBox.SelectedIndex != -1)
                {
                    new Thread(() => sortFriendsList(sortMethod)).Start();
                }
            }
            catch (Exception)
            {
            }
        }

        private void sortFriendsList(int i_SortMethod)
        {
            eSortType eSortType = i_SortMethod == 0 ? eSortType.Ascending : eSortType.Desending;

            listViewFriends.Invoke(new Action(() => listViewFriends.Items.Clear()));
            setFriendsListView(r_FacebookFeaturesFacade.SortFriendsByStrategy(eSortType));
        }
    }
}
