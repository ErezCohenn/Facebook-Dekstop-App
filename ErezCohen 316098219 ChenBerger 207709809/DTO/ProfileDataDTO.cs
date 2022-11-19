using FacebookWrapper.ObjectModel;

namespace DTO
{
    public class ProfileDataDTO
    {
        private string m_FirstName;
        private string m_LastName;
        private City m_HomeTown;
        private string m_Birthday;
        private string m_Email;
        private string m_About;

        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public City HomeTown { get => m_HomeTown; set => m_HomeTown = value; }
        public string Birthday { get => m_Birthday; set => m_Birthday = value; }
        public string Email { get => m_Email; set => m_Email = value; }
        public string About { get => m_About; set => m_About = value; }
    }
}
