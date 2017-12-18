using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.MusteriGiris.Bussiness
{
    #region Musteri


    /// <summary>
    /// Müşteri toplaosundaki her kaydı temsil eden class.
    /// </summary>
 public class Musteri
    {

        public long? HesapNo { set; get; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long? TcNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public long? Yas { get; set; }
        public string Cinsiyet { set; get; }
        public string Adres { get; set; }
        public long? TelNo { get; set; }
        public string Email { get; set; }
        public string MusteriCinsiKodu { get; set; }
        public long? UyrukKodu { get; set; }
        public long? CografiBolgeKodu { get; set; }
        public long? SubeKodu { set; get; }

        

        public Musteri()
        {

        }

        /// <summary>
        /// tablonun satırlarındaki bilgileri nesnenin içinde uygun yerlere set eden constractor
        /// </summary>
        /// <param name="mstrRow"></param>
        public Musteri(DataRow mstrRow)
        {
            HesapNo = ConvertHelper.ConvertTo<long>(mstrRow["HESAP_NO"]);
            Ad = mstrRow["AD"].ToString();
            Soyad = mstrRow["SOYAD"].ToString();
            TcNo = ConvertHelper.ConvertTo<long>(mstrRow["TC_NO"]);
            DogumTarihi = ConvertHelper.ConvertTo<DateTime>(mstrRow["DOGUM_TARIHI"]);
            Yas = ConvertHelper.ConvertTo<long>(mstrRow["YAS"]);
            Cinsiyet = mstrRow["CINSIYET"].ToString();
            Adres = mstrRow["ADRESI"].ToString();
            TelNo = ConvertHelper.ConvertTo<long>(mstrRow["TEL_NO"]);
            Email = mstrRow["E_MAIL"].ToString();
            MusteriCinsiKodu=mstrRow["MUSTERI_CINSI_KODU"].ToString();
            UyrukKodu = ConvertHelper.ConvertTo<long>(mstrRow["UYRUK_KODU"]);
            CografiBolgeKodu = ConvertHelper.ConvertTo<long>(mstrRow["COGRAFİ_BÖLGE_KODU"]);
            SubeKodu = ConvertHelper.ConvertTo<long>(mstrRow["SUBE_KODU"]);

        }

        /// <summary>
        /// nesne içindeki bilgi grilmesi zorunlu olan alanların zorunluluk kontrolunu yapar 
        /// </summary>
        /// <returns></returns>
        public bool ZorunlulukKontrol()
        {
            StringBuilder strMesaj = new StringBuilder();

            if (string.IsNullOrEmpty(Ad))
            {
                strMesaj.AppendLine("Ad bilgisini giriniz.");
            }

            if (string.IsNullOrEmpty(Soyad))
            {
                strMesaj.AppendLine("Soyad bilgisini giriniz.");
            }

             if (!TcNo.HasValue)
            {
                strMesaj.AppendLine("TcNo bilgisi giriniz");
            }

             if (!DogumTarihi.HasValue)
            {
                strMesaj.AppendLine("Doğum Tarihi bilgisi giriniz");
            }

             if (!Yas.HasValue)
            {
                strMesaj.AppendLine("Yas  bilgisi giriniz");
            }

             if (string.IsNullOrEmpty(Cinsiyet))
            {
                strMesaj.AppendLine("Cinsiyet bilgisi giriniz");
            }

             if (!TelNo.HasValue)
            {
                strMesaj.AppendLine("Telefon bilgisi giriniz");
            }

            if (string.IsNullOrEmpty(Email))
            {
                strMesaj.AppendLine("Email Adres bilgisini giriniz.");
            }

             if (string.IsNullOrEmpty(Adres))
            {
                strMesaj.AppendLine("Adres bilgisini giriniz."); 
            }

             if (!SubeKodu.HasValue)
            {
                strMesaj.AppendLine("Sube kodu bilgisi giriniz");
            }

             if (string.IsNullOrEmpty(MusteriCinsiKodu))
            {
                strMesaj.AppendLine("Müsteri cinsi kodu bilgisi giriniz");
            }
             if (!UyrukKodu.HasValue)
            {
                strMesaj.AppendLine("Uyruk kodu bilgisi giriniz");
            }
             if (!CografiBolgeKodu.HasValue)
            {
                strMesaj.AppendLine("Coğrafi bölge kodu bilgisi giriniz");
            }
             if (!string.IsNullOrEmpty(strMesaj.ToString()))
                 
                 throw new Exception(strMesaj.ToString());
             return true ;

        }

    }
}
    #endregion