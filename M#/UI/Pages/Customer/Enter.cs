using MSharp;

namespace Customer
{
    public class EnterPage : SubPage<CustomersPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.CustomerForm>();
        }
    }
}