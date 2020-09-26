using System.Web;
using System.Web.Mvc;
using TheFunctionalAthlete.Infrastructure;

namespace TheFunctionalAthlete.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new TransactionFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
