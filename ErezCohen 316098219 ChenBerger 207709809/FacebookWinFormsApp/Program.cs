using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            UIManager uIManager = new UIManager();

            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            uIManager.StartApp();
        }
    }
}
