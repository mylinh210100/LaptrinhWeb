using DataIO.EF;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tieuluan_LTWeb.Areas.Admin.Data;
using Tieuluan_LTWeb.Models;

namespace Tieuluan_LTWeb.Areas.Admin.Controllers
{
    public class DangNhapController : Controller
    {
        private WebPhim db = new WebPhim();

        // GET: Admin/DangNhap
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin taiKhoan)
        {
            if (ModelState.IsValid)
            {
                TaiKhoan tk = db.TaiKhoans.SingleOrDefault(x => x.TenTaiKhoan == taiKhoan.Username && x.PassWord == taiKhoan.Pass);
                if (tk != null)
                {
                    IEnumerable<QuyenUser> listQ = db.QuyenUsers.Where(x => x.TenTaiKhoan == taiKhoan.Username);
                    string quyen = "";
                    foreach (var item in listQ)
                    {
                        quyen += item.QuyenSuDung.TenQuyen + ",";
                    }
                    quyen = quyen.Substring(0, quyen.Length - 1);
                    Permission(tk.TenTaiKhoan, quyen);

                    var user = new UserCode().GetByName(taiKhoan.Username);
                    var usession = new User();

                    usession.userName = user.TenTaiKhoan;
                    Session.Add(SessionCommon.USER_SESSION, usession);

                    return RedirectToAction("Index", "AdHome");
                }
            }

            return View("Login");
        }

        public void Permission(string username, string permis)
        {
            FormsAuthentication.Initialize();
            var info = new FormsAuthenticationTicket(1,
                                                    username,
                                                    DateTime.Now,
                                                    DateTime.Now.AddHours(2),
                                                    false,
                                                    permis,
                                                    FormsAuthentication.FormsCookiePath);
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(info));
            if (info.IsPersistent)
            {
                cookie.Expires = info.Expiration;
            }
            Response.Cookies.Add(cookie);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}