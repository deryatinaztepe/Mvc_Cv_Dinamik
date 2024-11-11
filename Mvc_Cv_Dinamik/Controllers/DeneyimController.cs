using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Cv_Dinamik.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo=new DeneyimRepository();
        public ActionResult Index()
        {
            var values=repo.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
		public ActionResult DeneyimEkle(Tbl_Deneyimler p)
		{
			repo.TAdd(p);
            return RedirectToAction("Index");
		}
        public ActionResult DeneyimSil(int id)
        {
            Tbl_Deneyimler t=repo.Find(x=>x.ID==id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            Tbl_Deneyimler t=repo.Find(x=>x.ID == id);
            return View(t);
        }
		[HttpPost]
		public ActionResult DeneyimGetir(Tbl_Deneyimler p)
		{
			Tbl_Deneyimler t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.AltBaslik = p.AltBaslik;
            t.Tarih=p.Tarih;
            t.Aciklama=p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
		}
	}
}