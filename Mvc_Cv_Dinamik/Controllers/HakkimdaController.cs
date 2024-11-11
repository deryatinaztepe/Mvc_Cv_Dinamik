using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;

namespace Mvc_Cv_Dinamik.Controllers
{
    public class HakkimdaController : Controller
    {
        // GET: Hakkimda
        GenericRepository<Tbl_Hakkimda> repo = new GenericRepository<Tbl_Hakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(Tbl_Hakkimda hk)
        {
            var h = repo.Find(x => x.ID == 1);
            h.Ad = hk.Ad;
            h.Soyad= hk.Soyad;
            h.Adres= hk.Adres;
            h.Mail= hk.Mail;
            h.Telefon= hk.Telefon;
            h.Resim= hk.Resim;
            repo.TUpdate(h);
            return RedirectToAction("Index");
        }
    }
}