using BankApplication.FrameWork.CommonHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BankApplication.KullaniciGirisi.Bussiness
{
    public class KullaniciGirisLib
    {
        public string KullaniciAd { set; get; }
        public string KullaniciSifre { set; get; }
          

        public KullaniciGirisLib()
        {

        }

        public KullaniciGirisLib(DataRow klncRow)
        {

            KullaniciAd = klncRow["KULLANICI_ADI"].ToString();
            KullaniciSifre = klncRow["KULLANICI_SIFRE"].ToString();
            
        }
    }
}
