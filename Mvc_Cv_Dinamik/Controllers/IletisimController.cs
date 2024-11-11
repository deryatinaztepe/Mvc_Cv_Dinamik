using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Cv_Dinamik.Models.Entitiy;
using Mvc_Cv_Dinamik.Repositories;

namespace Mvc_Cv_Dinamik.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Tbl_Iletisim> repo = new GenericRepository<Tbl_Iletisim>();
        public ActionResult Index()
        {
            var mesajlar=repo.List();
            return View(mesajlar);
        }
    }
}