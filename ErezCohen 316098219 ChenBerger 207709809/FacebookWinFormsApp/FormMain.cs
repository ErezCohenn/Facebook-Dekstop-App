using DTO;

using FacebookLogic;
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
            setFacebookTopLogo();
            fetchUserData();

        }

        private void fetchUserData()
        {
            fetchFriendsList();
            fetchImageProfile();
            fetchProfileData();
        }

        private void fetchProfileData()
        {
            ProfileDataDTO profileDataDTO = m_LogicManager.GetProfileData();
            //Location userLocation = profileDataDTO.HomeTown.Location;

            this.labelFirstName.Text += profileDataDTO.FirstName;
            this.labelLastName.Text += profileDataDTO.LastName;
            this.labelEmail.Text += profileDataDTO.Email;
            this.labelBirthday.Text += profileDataDTO.Birthday;

            //if (userLocation != null)
            {
                //   this.labelHomeTown.Text = userLocation.Country + " " + userLocation.City + " " + userLocation.Street;
            }

            //pictureBoxProfile.LoadAsync(profileDataDTO.HomeTown.PictureURL);
        }

        private void setFacebookTopLogo()
        {
            pictureBoxTopLogo.Image = Image.FromFile(Resources.FacebookLogoFullPath);
            pictureBoxTopLogo.Enabled = false;
            pictureBoxTopLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void fetchImageProfile()
        {
            pictureBoxProfile.LoadAsync(m_LogicManager.GetUserProfileImageUrl());
        }

        private void fetchFriendsList()
        {
            FriendsListDTO friendsListDTO;
            int friendIndex = 0;

            listViewFriends.View = View.Details;
            listViewFriends.Columns.Add("Friends:", 200);
            m_FriendsImagesList = new ImageList();
            m_FriendsImagesList.ImageSize = new Size(50, 50);

            try
            {
                friendsListDTO = m_LogicManager.GetFriendsList();
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogicManager.Logout();
            m_IsLogoutButtonClicked = true;
            this.Close();
        }
    }
}
