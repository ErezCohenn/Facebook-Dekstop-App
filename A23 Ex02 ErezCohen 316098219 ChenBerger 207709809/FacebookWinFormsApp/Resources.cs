using System.IO;

namespace BasicFacebookFeatures
{
    public class Resources
    {
        private static readonly string sr_FacebookLogo = "facebookLogo.png";
        private static readonly string sr_FacebookLogin = "facebookLogin.png";
        private static readonly string sr_FacebookDefultPicture = "defultFacebookPicture.png";
        private static readonly string sr_ResourcesFolderPath;

        static Resources()
        {
            sr_ResourcesFolderPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Resources");
        }

        public static string ResourcesFolderPath
        {
            get
            {
                return sr_ResourcesFolderPath;
            }
        }

        public static string FacebookLogoFullPath
        {
            get
            {
                return Path.Combine(sr_ResourcesFolderPath, sr_FacebookLogo);
            }
        }

        public static string FacebookLoginFullPath
        {
            get
            {
                return Path.Combine(sr_ResourcesFolderPath, sr_FacebookLogin);
            }
        }

        public static string FacebookDefultPicturePath
        {
            get
            {
                return Path.Combine(sr_ResourcesFolderPath, sr_FacebookDefultPicture);
            }
        }
    }
}
