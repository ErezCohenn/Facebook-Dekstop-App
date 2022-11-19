using DTO;
using FacebookLogic;
using Project1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FormLogin m_FormLogin;
        LogicManager m_LogicManager;
        ImageList m_FriendsImagesList;

        public FormMain()
        {
            InitializeComponent();
            setFacebookTopLogo();
            m_LogicManager = new LogicManager();
            m_FormLogin = new FormLogin(m_LogicManager);
            registerToEvents();
        }

        private void registerToEvents()
        {
            this.m_FormLogin.FormClosed += new FormClosedEventHandler(this.FormLogin_FormClosed);
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

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_FormLogin = sender as FormLogin;

            if (e.CloseReason == CloseReason.UserClosing && !m_FormLogin.IsFormClosedBySucceedLogin)
            {
                this.Close();
            }
            else
            {
                this.Show();
                fetchUserData();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LogicManager.Logout();
            this.Hide();
            m_FormLogin.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            m_FormLogin.ShowDialog();
        }
    }
}
