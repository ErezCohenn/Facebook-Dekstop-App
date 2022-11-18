using System;
using System.Collections.Generic;
using System.IO;

namespace FacebookLogic
{
    public class AppSettings
    {
        private string m_AppID = "852667072827918";
        private List<string> m_Permissions;
        private const string k_EndOfLastAccessTokenFilePath = "FacebookAppAccessToken.txt";
        private readonly string r_FullLastAccessTokenFilePath;

        public AppSettings()
        {
            m_Permissions = new List<string>();
            r_FullLastAccessTokenFilePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"FacebookAppAccessToken.txt");
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
        public void SaveCurrentAccessTokenToFile(string i_CurrentAccessToken)
        {
            using (StreamWriter streamWriter = new StreamWriter(r_FullLastAccessTokenFilePath))
            {
                streamWriter.WriteLine(i_CurrentAccessToken);
            }
        }
        public string GetAccessTokenFromFile()
        {
            string accessToken = string.Empty;

            try
            {
                accessToken = File.ReadAllText(r_FullLastAccessTokenFilePath);
            }
            catch (IOException ioException) { };

            return accessToken;
        }
        public bool HasAccessToken()
        {
            return !string.IsNullOrEmpty(GetAccessTokenFromFile());
        }

        public void ClearAccessToken()
        {
            File.Delete(r_FullLastAccessTokenFilePath);
        }
    }
}
