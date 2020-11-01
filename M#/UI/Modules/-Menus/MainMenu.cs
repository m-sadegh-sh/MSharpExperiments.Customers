using MSharp;

using System.Security.Cryptography.X509Certificates;

namespace Modules
{
    public class MainMenu : MenuModule
    {
        public MainMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            AjaxRedirect().WrapInForm(false);
            Using("Olive.Security");
            IsViewComponent().UlCssClass("nav flex-column");
            RootCssClass("sidebar-menu");

            Link("Logout00")
                 .CssClass("align-bottom logout00")
                 .ValidateAntiForgeryToken(false)
                 .VisibleIf(CommonCriterion.IsUserLoggedIn)
                 .OnClick(x =>
                 {
                     x.CSharp("await OAuth.Instance.LogOff();");
                     x.Go<LoginPage>();
                 });
        }
    }
}