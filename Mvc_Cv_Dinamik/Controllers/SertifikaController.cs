using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;

namespace Mvc_Cv_Dinamik.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<Tbl_Sertifikalar> repo = new GenericRepository<Tbl_Sertifikalar>();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertfika=repo.Find(x=>x.ID==id);
            ViewBag.d = id;
            return View(sertfika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(Tbl_Sertifikalar stk)
        {
            var sertifika=repo.Find(x=>x.ID == stk.ID);
            sertifika.Aciklama = stk.Aciklama;
            sertifika.Tarih = stk.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(Tbl_Sertifikalar p )
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
           
            repo.TDelete(sertifika);
            return RedirectToAction("Index");
        }
    }
}