using MSharp;

namespace Admin.Settings
{
    public class GeneralPage : SubPage<SettingsPage>
    {
        public GeneralPage()
        {
            Add<Modules.GeneralSettingsForm>();
        }
    }
}