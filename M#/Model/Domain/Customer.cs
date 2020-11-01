using MSharp;

namespace Domain
{
    public class Customer : EntityType
    {
        public Customer()
        {
            Associate<Country>("Country")
                .Mandatory(true);

            String("Company name")
                .Mandatory(true);

            Date("Contract start date")
                .Mandatory(true);

            OpenImage("Logo")
                .Width(200)
                .Height(80)
                .Mandatory(false);

            OpenFile("Contract")
                .Mandatory(false);
        }
    }
}