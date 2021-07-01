using DataIO.EF;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tieuluan_LTWeb.Controllers
{
    public class HomeController : Controller
    {
        WebPhim db = new WebPhim();
        public ActionResult Index()
        {
            var list = new Phimcode().ListPhim();
            return View(list);
        }
 
        public ActionResult XemPhim(int id)
        {
            var link = new Phimcode().VideoPhim(id);
            ViewBag.Binhluan = new BinhluanCode().ViewBinhLuan(id);
            return View(link);
        }

        public ActionResult MenuLogin()
        {
            return PartialView("MenuLogin");
        }

        public ActionResult ChudePhim()
        {
            var chude = new ChudePhimCode().ListChude();
            return PartialView(chude);
        }

    }
}