using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FacebookLogic
{
    public class AppSettings
    {
        private static readonly string sr_FullFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"FacebookAppSettings.xml");
        private readonly List<string> r_Permissions;
        private string m_AppID;

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            r_Permissions = new List<string>();
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = null;

            try
            {
                using (Stream stream = new FileStream(sr_FullFilePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }
            catch (Exception)
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public string AppID { get => m_AppID; set => m_AppID = value; }

        public List<string> Permissions { get => r_Permissions; }

        public void AddPermission(string i_Permission)
        {
            r_Permissions.Add(i_Permission);
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
