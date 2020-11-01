using MSharp;

namespace Country
{
    public class CountriesPage : SubPage<CountryPage>
    {
        public CountriesPage()
        {
            Add<Modules.CountriesList>();
        }
    }
}