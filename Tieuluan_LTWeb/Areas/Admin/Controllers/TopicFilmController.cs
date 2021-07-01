using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Tieuluan_LTWeb.Areas.Admin.Controllers
{
    
    public class TopicFilmController : BaseController
    {
        private WebPhim db = new WebPhim();

        // GET: Admin/TopicFilm
        public ActionResult Topic()
        {
            var listtopic = db.ChuDes.ToList();
            return View(listtopic);
        }


        [HttpGet]
        public ActionResult InsertNew()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertNew(ChuDe topic)
        {
            if (ModelState.IsValid)
            {
                var rs = db.ChuDes.Add(topic);
                db.SaveChanges();
                if (rs != null)
                {
                    return RedirectToAction("Topic");
                }
                else
                {
                    ModelState.AddModelError("", "Insert fail!");
                }
            }
            return View(topic);
        }




        public ActionResult TopicFilm(int idchude)
        {
            var list = db.Phim_ChuDe.Where(x=>x.idChuDe == idchude).ToList();
            return View(list);
        }

        public void SetViewBag(int selectedId = 0)
        {
            var listid = db.Phims.Where(x => x.idPhim > 0).ToList();

            ViewBag.idPhim = new SelectList(listid, "idPhim", "TenPhim", selectedId);
        }

        [HttpGet]
        public ActionResult SettopicFilm()
        {
            SetViewBag();
            return View();
        }



        [HttpPost]
        public ActionResult SettopicFilm(Phim_ChuDe idcd)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var model = db.Phim_ChuDe.Add(idcd);
                    db.SaveChanges();
                    if (model != null)
                    {
                        return RedirectToAction("Topic");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Fail");
                    }
                    
                }
                return View(idcd);
            }
            catch (Exception)
            {

                return View();
            }
        }





    }
}