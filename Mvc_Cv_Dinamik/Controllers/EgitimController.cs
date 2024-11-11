using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Cv_Dinamik.Controllers
{
    [Authorize]
    public class EgitimController : Controller
    {
    
        // GET: Egitim
        GenericRepository<Tbl_Egitim> repo=new GenericRepository<Tbl_Egitim> ();
       
        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        [HttpGet]
        public ActionResult EgitimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EgitimEkle(Tbl_Egitim e)
        {
            if(!ModelState.IsValid)
            {
                return View("EgitimEkle");
            }
            repo.TAdd(e);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimSil(int id)
        {
            var egitim=repo.Find(x=>x.ID==id);
            repo.TDelete(egitim);
            return RedirectToAction("Index");
        }
        public ActionResult EgitimDuzenle(int id)
        {
            var egitim=repo.Find(x=>x.ID== id);
            return View(egitim);
        }
        [HttpPost]
        public ActionResult EgitimDuzenle(Tbl_Egitim et)
        {
            if (!ModelState.IsValid)
            {
                return View("EgitimDuzenle");
            }
            var egitim = repo.Find(x => x.ID == et.ID);
            egitim.Baslik = et.Baslik;
            egitim.AltBaslik1=et.AltBaslik1;
            egitim.AltBaslik2 = et.AltBaslik2;
            egitim.Tarih=et.Tarih;
            egitim.GenelNotOrt = et.GenelNotOrt;
            repo.TUpdate(egitim);
            return RedirectToAction("Index");
        }
    }
}