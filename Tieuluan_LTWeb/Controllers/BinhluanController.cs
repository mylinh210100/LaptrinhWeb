using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tieuluan_LTWeb.Controllers
{
    public class BinhluanController : Controller
    {
        WebPhim db = new WebPhim();
        // GET: Binhluan
        public ActionResult VietBinhluan(FormCollection form)
        {
            try
            {
                var comment = new BinhLuan();
                comment.idPhim = int.Parse(form["idPhim"]);
                comment.TenTaiKhoan = string.Concat(form["taikhoan"]);
                comment.NoiDung = string.Concat(form["noidung"]);
                db.BinhLuans.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            catch (Exception)
            {
                return Content("ERROR");
            }
        }
    }
}