using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        private string m_AppID;
        private List<string> m_Permissions;

        public AppSettings()
        {
            m_Permissions = new List<string>();
        }

        public string AppID { get => m_AppID; set => m_AppID = value; }
        public List<string> Permissions { get => m_Permissions; set => m_Permissions = value; }

        public void AddPremission(string i_Premission)
        {
            if (m_Permissions == null)
            {
                m_Permissions = new List<string>();
            }

            m_Permissions.Add(i_Premission);
        }
    }
}
