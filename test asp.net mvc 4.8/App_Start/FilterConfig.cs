using System.Web;
using System.Web.Mvc;

namespace test_asp.net_mvc_4._8
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
