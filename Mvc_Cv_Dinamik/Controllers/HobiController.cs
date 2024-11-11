using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;

namespace Mvc_Cv_Dinamik.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<Tbl_Hobiler> repo=new GenericRepository<Tbl_Hobiler>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(Tbl_Hobiler hb)
        {
            //Tbl_Hobiler h = new Tbl_Hobiler();
            var h=repo.Find(x=>x.ID==1);
            h.Aciklama1 = hb.Aciklama1;
            h.Aciklama2 = hb.Aciklama2;
            repo.TUpdate(h);
            return RedirectToAction("Index");

        }
    }
}