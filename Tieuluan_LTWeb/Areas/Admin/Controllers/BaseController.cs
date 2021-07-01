using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tieuluan_LTWeb.Areas.Admin.Data;
using Tieuluan_LTWeb.Models;

namespace Tieuluan_LTWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (User)Session[SessionCommon.USER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    System.Web.Routing.RouteValueDictionary(new
                    {
                        controller = "DangNhap",
                        action = "Login",
                        Areas = "Admin"
                    }
                    ));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}