using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;
namespace Mvc_Cv_Dinamik.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
        GenericRepository<Tbl_SosyalMedya> repo = new GenericRepository<Tbl_SosyalMedya>();
        public ActionResult Index()
        {
            var sosyalmedya = repo.List();
            return View(sosyalmedya);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Tbl_SosyalMedya s)
        {
            repo.TAdd(s);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap=repo.Find(x=>x.ID==id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(Tbl_SosyalMedya sm)
        {
            var hesap = repo.Find(x => x.ID ==sm.ID);
            hesap.Ad=sm.Ad;
            hesap.Durum = true;
            hesap.Link=sm.Link;
            hesap.ikon=sm.ikon;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var hesap=repo.Find(x=>x.ID ==id);
            hesap.Durum = false;
            repo.TUpdate(hesap);
            return RedirectToAction("Index");
        }
    }
}