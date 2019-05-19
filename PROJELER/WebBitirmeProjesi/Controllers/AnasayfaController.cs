using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBitirmeProjesi.DbEntity;

namespace WebBitirmeProjesi.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        public ActionResult Index()
        {
            LOKANTAEntities db = new LOKANTAEntities();
            db.KISILER.ToList();
            List<HABER> y = db.HABER.ToList();

            string habericerk = y.Where(x => x.HaberId == 1).FirstOrDefault().HaberIcerik;
            string haberbaslik = y.Where(x => x.HaberId == 1).FirstOrDefault().HaberBaslik;

            ViewBag.Icerik = habericerk;
            ViewBag.Baslik = haberbaslik;



            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}