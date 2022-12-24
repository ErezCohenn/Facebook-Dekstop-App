namespace FacebookLogic
{
    public class AppSettingsFacade
    {
        private readonly LogicManager r_LogicManager;

        public AppSettingsFacade()
        {
            r_LogicManager = LogicManager.Instance;
        }

        public void SetAppId(string i_AppId)
        {
            r_LogicManager.SetAppId(i_AppId);
        }

        public void AddPermission(string i_Premission)
        {
            r_LogicManager.AddPermission(i_Premission);
        }
    }
}
