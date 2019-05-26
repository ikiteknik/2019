using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebBitirmeProjesi.DbEntity;

namespace WebBitirmeProjesi.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        public HABER MainLayoutViewModel { get; set; }

        public ActionResult Index()
        {
            LOKANTAEntities db = new LOKANTAEntities();
            db.KISILER.ToList();
            List<HABER> y = db.HABER.ToList();

            string habericerk = y.Where(x => x.HaberId == 1).FirstOrDefault().HaberIcerik;
            string haberbaslik = y.Where(x => x.HaberId == 1).FirstOrDefault().HaberBaslik;

            ViewBag.Icerik = habericerk;
            ViewBag.Baslik = haberbaslik;
            ViewBag.Liste = y;


            //MainLayoutViewModel = new HABER();
            //ViewBag.MainLayoutViewModel = MainLayoutViewModel;
            // ViewData["MainLayoutViewModel"] =MainLayoutViewModel;


            return View(y);
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session[Helper.Sabitler.SessionKisiKey] = null;
            return RedirectToAction("Login", "Anasayfa");
        }

        [HttpPost]
        public ActionResult Login(string sifre, string mail)
        {

            YetkiBS yet = new YetkiBS();
            int kisiKey = yet.YetkiliMi(sifre, mail);

            if (kisiKey > 0)
            {
                // return Redirect("~/Home/Index");
                // FormsAuthentication.SetAuthCookie(kisiKey.ToString(), false);
                //return RedirectToAction("Index", "Home", new { kisiKey = kisiKey });
                Session[Helper.Sabitler.SessionKisiKey] = kisiKey.ToString();

                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public ActionResult Kaydet(string txtadi, string txtsoyad)
        {
            return RedirectToAction("Index");
        }

        [HttpPost]

        public ActionResult KaydetModel(HABER p)
        {
            HABER s = new HABER();
            s.HaberBaslik = p.HaberBaslik;
            s.HaberIcerik = p.HaberIcerik;
            s.HaberOnyazi = p.HaberOnyazi;
            s.HaberTuru = 1;
            s.YayinlanmaTarihi = DateTime.Now;

            LOKANTAEntities db = new LOKANTAEntities();
            db.HABER.Add(s);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult DeleteHaber(int id)
        {

            if (id != null && id > 0)
            {
                LOKANTAEntities db = new LOKANTAEntities();
                HABER silinecek = db.HABER.Where(x => x.HaberId == id).FirstOrDefault();
                db.HABER.Remove(silinecek);
                db.SaveChanges();
            }


            return RedirectToAction("Index");
        }


        public ActionResult UpdateHaber(int id)
        {
            LOKANTAEntities db = new LOKANTAEntities();
            HABER updatedilecekhaber = db.HABER.Where(x => x.HaberId == id).FirstOrDefault();

            return View(updatedilecekhaber);
        }


        [HttpPost]
        public ActionResult UpdateHaber(HABER hbr)
        {

            LOKANTAEntities db = new LOKANTAEntities();

            db.HABER.Attach(hbr);
            db.Entry(hbr).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "Anasayfa");

        }



    }
}