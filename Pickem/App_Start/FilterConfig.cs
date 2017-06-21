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
            // except certain pages under the AccountController because pages like Login and Register
            // must allow anonymous connections to allow users to login or register.
            filters.Add(new AuthorizeAttribute());
        }
    }
}
