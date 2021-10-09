using System.Web;
using System.Web.Mvc;

namespace WebAPI_project_assignment1_LisleLojo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
