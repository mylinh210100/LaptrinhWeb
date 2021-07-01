using DataIO.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tieuluan_LTWeb.Controllers
{
    public class PhimController : Controller
    {
        // GET: Phim
        public ActionResult Film(int idcd)
        {
            var list = new Phimcode().FilmbyTopic(idcd);
            return View(list);
        }
    }
}