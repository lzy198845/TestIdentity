using System.Web;
using System.Web.Mvc;
using TestEmptyIdentity.App_Start;

namespace TestEmptyIdentity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new MyAuthorizeAttribute());//全局权限
            filters.Add(new HandleErrorAttribute());
        }
    }
}
