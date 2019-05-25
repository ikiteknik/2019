using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBitirmeProjesi.DbEntity;

namespace WebBitirmeProjesi
{
    public class YetkiBS
    {

        public int YetkiliMi(string sifre, string mail)
        {
            LOKANTAEntities db = new LOKANTAEntities();
            KISILER varmi = db.KISILER.Where(x => x.EPosta == mail && x.Sifre == sifre).FirstOrDefault();

            if (varmi != null)
            {
                return varmi.KisiKey;
            }
            else
            {
                return 0;
            }
        }

        public KISILER KisiBilgileriGetir(int KisiKey)
        {
            LOKANTAEntities db = new LOKANTAEntities();
            KISILER varmi = db.KISILER.Where(x => x.KisiKey == KisiKey).FirstOrDefault();


            return varmi;
          
        }
    }
}