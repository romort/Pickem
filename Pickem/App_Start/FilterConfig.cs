using System.Web;
using System.Web.Mvc;

namespace Pickem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // Requires user to be logged in to view any page in site
            // except those pages under the AccountController because AccountController allows anonymous by default
            // for obvious reasons.
            filters.Add(new AuthorizeAttribute());
        }
    }
}
