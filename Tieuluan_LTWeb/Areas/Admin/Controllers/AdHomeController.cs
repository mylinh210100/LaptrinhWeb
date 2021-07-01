using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Tieuluan_LTWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdHomeController : BaseController
    {
        // GET: Admin/AdHome
        public ActionResult Index()
        {
            return View();
        }





    }
}