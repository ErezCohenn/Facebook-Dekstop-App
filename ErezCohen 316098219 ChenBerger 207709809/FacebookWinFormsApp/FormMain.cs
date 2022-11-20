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
        }

        private void fetchAlbums()
        {
            FacebookObjectCollection<Album> albums = m_LogicManager.FetchAlbums();

            foreach (Album album in albums)
            {
                //album.
            }
        }

        private void fetchPosts()
        {
            FacebookObjectCollection<Post> posts = m_LogicManager.FetchPosts();
            flowLayoutPanelPosts.Controls.Clear();
            foreach (Post post in posts)
            {
                PostPanel postPanel = new PostPanel(post);
                flowLayoutPanelPosts.Controls.Add(postPanel);
            }

            if (flowLayoutPanelPosts.Controls.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }

        private void fetchProfileData()
        {
            ProfileDataDTO profileDataDTO = m_LogicManager.FetchProfileData();
            City userCity = profileDataDTO.HomeTown;
            Location userLocation = null;

            this.labelFirstName.Text = "First Name: " + profileDataDTO.FirstName;
            this.labelLastName.Text = "Last Name: " + profileDataDTO.LastName;
            this.labelEmail.Text = "Email: " + profileDataDTO.Email;
            this.labelBirthdate.Text = "Birthday Date: " + profileDataDTO.Birthday;
            this.labelFacebook.Text = profileDataDTO.FirstName + "book";

            if (userCity != null)
            {
                userLocation = userCity.Location;
                this.labelHomeTown.Text = userLocation.Country + " " + userLocation.City + " " + userLocation.Street;
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
            listViewFriends.Columns.Add("Friends:", 200);
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
        //private void fetchGroups()
        //{
        //    listBoxGroups.Items.Clear();
        //    listBoxGroups.DisplayMember = "Name";
        //
        //    try
        //    {
        //        FacebookObjectCollection<Group> groups = m_LogicManager.FetchGroups();
        //        foreach (Group group in groups)
        //        {
        //            listBoxGroups.Items.Add(group);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //
        //    if (listBoxGroups.Items.Count == 0)
        //    {
        //        MessageBox.Show("No groups to retrieve :(");
        //    }
        //}
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogicManager.Logout();
            m_IsLogoutButtonClicked = true;
            this.Close();
        }
    }
}
