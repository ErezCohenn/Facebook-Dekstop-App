using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FacebookLogic
{
    public class AppSettings
    {
        private static readonly string sr_FullFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"FacebookAppSettings.xml");
        private string m_AppID;
        private List<string> m_Permissions;

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            m_Permissions = new List<string>();
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = null;

            try
            {
                using (Stream stream = new FileStream(sr_FullFilePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    obj = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }
            catch (Exception)
            {
                obj = new AppSettings();
            }

            return obj;
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
                using (Stream stream = new FileStream(sr_FullFilePath, FileMode.CreateNew))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                    xmlSerializer.Serialize(stream, this);
                }
            }
            catch (IOException)
            {
                using (Stream stream = new FileStream(sr_FullFilePath, FileMode.Truncate))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                    xmlSerializer.Serialize(stream, this);
                }
            }
        }
    }
}
