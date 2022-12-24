namespace FacebookLogic
{
    public class AppSettingsFacade
    {
        public void SetAppId(string i_AppId)
        {
            LogicManager.Instance.SetAppId(i_AppId);
        }

        public void AddPermission(string i_Premission)
        {
            LogicManager.Instance.AddPermission(i_Premission);
        }
    }
}
