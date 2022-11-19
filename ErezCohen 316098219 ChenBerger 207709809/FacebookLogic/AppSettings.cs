using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FacebookLogic
{
    public class AppSettings
    {
        private string m_AppID;
        private List<string> m_Permissions;
        private readonly string r_FullFilePath;
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        public AppSettings()
        {
            m_Permissions = new List<string>();
            r_FullFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"FacebookAppSettings.xml");
        }

        public string AppID { get => m_AppID; set => m_AppID = value; }
        public List<string> Permissions { get => m_Permissions; set => m_Permissions = value; }

        public void AddPermission(string i_Permission)
        {
            if (m_Permissions == null)
            {
                m_Permissions = new List<string>();
            }
            m_Permissions.Add(i_Permission);
        }
        public void SaveToFile(string i_CurrentAccessToken)
        {
            LastAccessToken = i_CurrentAccessToken;
            try
            {
                using (Stream stream = new FileStream(r_FullFilePath, FileMode.CreateNew))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                    xmlSerializer.Serialize(stream, this);

                }
            }
            catch (IOException ioExeption)
            {
                using (Stream stream = new FileStream(r_FullFilePath, FileMode.Truncate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                    xmlSerializer.Serialize(stream, this);
                }
            }
            //using (StreamWriter streamWriter = new StreamWriter(r_FullFilePath))
            //{
            //    streamWriter.WriteLine(i_CurrentAccessToken);
            //}

        }
        public string LoadFromFile()
        {

            string accessToken = string.Empty;
            try
            {
                using (Stream stream = new FileStream(r_FullFilePath, FileMode.Truncate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                    AppSettings obj = xmlSerializer.Deserialize(stream) as AppSettings;
                    if (obj.RememberUser)
                    {
                        accessToken = obj.LastAccessToken;
                    }

                }
            }
            catch (IOException ioException) { }
            return accessToken;
        }
        public bool WantedToRememberUser()
        {
            return !string.IsNullOrEmpty(LoadFromFile());
        }
    }
}
