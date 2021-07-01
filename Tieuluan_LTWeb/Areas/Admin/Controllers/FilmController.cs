using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Tieuluan_LTWeb.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class FilmController : BaseController
    {
        private WebPhim db = new WebPhim();
        // GET: Admin/Film
        public ActionResult Film()
        {
            var list = db.Phims.ToList();
            return View(list);
        }


        [HttpGet]
        public ActionResult ThemFilm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemFilm(Phim p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   var rs = db.Phims.Add(p);
                    db.SaveChanges();
                    if (rs != null)
                    {
                        return RedirectToAction("Film");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Insert fail!");
                    }
                }
                return View(p);
            }
            catch (Exception)
            {
                return View();
            }

        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Phims.SingleOrDefault(x => x.idPhim == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Phim phim)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var model = db.Phims.Find(phim.idPhim);
                    model.TenPhim = phim.TenPhim;
                    model.MoTa = phim.MoTa;
                    model.Anh = phim.Anh;
                    model.Link = phim.Link;
                    db.SaveChanges();

                    return RedirectToAction("Film", "Film");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Update fail!");
                }

            }
            return View("Film");
        }

        public ActionResult Delete(int idphim)
        {
            if (idphim < 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phim p = db.Phims.Find(idphim);
            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int idphim)
        {
            Phim phim = db.Phims.Find(idphim);
            db.Phims.Remove(phim);
            db.SaveChanges();
            return RedirectToAction("Film");
        }



    }
}