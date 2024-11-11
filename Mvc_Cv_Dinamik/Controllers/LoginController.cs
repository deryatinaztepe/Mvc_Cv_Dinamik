using Mvc_Cv_Dinamik.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc_Cv_Dinamik.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tbl_Admin a)
        {
            Db_Cv_UdemyEntities2 db=new Db_Cv_UdemyEntities2();
            var bilgi = db.Tbl_Admin.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi && x.Sifre == a.Sifre);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false);
                Session["KullaniciAdi"] = bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index","Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
           
          }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}