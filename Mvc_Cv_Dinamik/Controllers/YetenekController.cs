using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;

namespace Mvc_Cv_Dinamik.Controllers
{
	public class YetenekController : Controller
	{
		// GET: Yetenek
		YetenekRepository repo = new YetenekRepository();
		public ActionResult Index()
		{
			var values = repo.List();
			return View(values);
		}
		[HttpGet]
		public ActionResult YeniYetenek()
		{
			return View();
		}
		[HttpPost]
		public ActionResult YeniYetenek(Tbl_Yetenekler p)
		{
			repo.TAdd(p);
			return RedirectToAction("Index");
		}
		public ActionResult YetenekSil(int id)
		{
			var yetenek = repo.Find(x => x.ID == id);
			repo.TDelete(yetenek);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public ActionResult YetenekDuzenle(int id)
		{
			var yetenek = repo.Find(x => x.ID == id);
			return View(yetenek);
		}
		[HttpPost]
		public ActionResult YetenekDuzenle(Tbl_Yetenekler t)
		{
			var yetenek = repo.Find(x => x.ID == t.ID);
			yetenek.Yetenek = t.Yetenek;
			yetenek.Oran = t.Oran;
			repo.TUpdate(yetenek);
			return RedirectToAction("Index");
		}
	}
}