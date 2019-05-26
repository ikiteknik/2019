using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBitirmeProjesi.DbEntity;

namespace WebBitirmeProjesi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            if (Session[Helper.Sabitler.SessionKisiKey] == null 
                        || string.IsNullOrEmpty(Session[Helper.Sabitler.SessionKisiKey].ToString()))
            {
                return RedirectToAction("Login", "Anasayfa");
            }
            else
            {
                string kisiKey = Session[Helper.Sabitler.SessionKisiKey].ToString();

                if (Convert.ToInt32(kisiKey) > 0)
                {
                    YetkiBS s = new YetkiBS();
                    KISILER kisi = s.KisiBilgileriGetir(Convert.ToInt32(kisiKey));

                    ViewBag.adi = kisi.KisiAdi;
                    return View();
                }
                else
                {
                    return RedirectToAction("Login", "Anasayfa");
                }
            }


            /// return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}