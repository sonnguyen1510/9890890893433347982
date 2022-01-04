using System.Web;
using System.Web.Mvc;

namespace Bán_Hàng_Onl_WebForm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
