using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace Tieuluan_LTWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            var usernamCookie = Context.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (usernamCookie != null)
            {
                var authTicket = FormsAuthentication.Decrypt(usernamCookie.Value);
                var permission = authTicket.UserData.Split(new Char[] { ',' });
                var userPrincipal = new GenericPrincipal(new GenericIdentity(authTicket.Name), permission);
                Context.User = userPrincipal;
            }
        }

    }
}
