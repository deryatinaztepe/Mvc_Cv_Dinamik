using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;


namespace Mvc_Cv_Dinamik.Controllers
{
	[AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        Db_Cv_UdemyEntities2 db=new Db_Cv_UdemyEntities2();
        public ActionResult Index()
        {
            var degerler=db.Tbl_Hakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.Tbl_SosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Deneyimler.ToList();
            return PartialView(deneyimler);
        }
		public PartialViewResult Egitim()
		{
			var egitimler = db.Tbl_Egitim.ToList();
			return PartialView(egitimler);
		}
		public PartialViewResult Yetenek()
		{
			var yetenekler = db.Tbl_Yetenekler.ToList();
			return PartialView(yetenekler);
		}
		public PartialViewResult Hobi()
		{
			var hobiler = db.Tbl_Hobiler.ToList();
			return PartialView(hobiler);
		}
		public PartialViewResult Sertifika()
		{
			var sertifikalar = db.Tbl_Sertifikalar.ToList();
			return PartialView(sertifikalar);
		}
		[HttpGet]
		public PartialViewResult Iletisim()
		{
			
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult Iletisim(Tbl_Iletisim t)
		{
			t.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
			db.Tbl_Iletisim.Add(t);
			db.SaveChanges();
			return PartialView();
		}
	}
}