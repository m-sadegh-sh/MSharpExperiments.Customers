using MSharp;

namespace Modules
{
    public class ConfirmPasswordReset : ViewModule<Domain.User>
    {
        public ConfirmPasswordReset()
        {
            HeaderText("@item Details").Markup("@ContentBlock.PasswordSuccessfullyReset.Content");

            Link("Proceed to the login page.").OnClick(x => x.Go<LoginPage>());
        }
    }
}