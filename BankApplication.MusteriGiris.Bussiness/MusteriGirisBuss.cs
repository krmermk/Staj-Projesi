using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApplication.Framework.BussHelper;
using System.Data;
using System.Data.SqlClient;

namespace BankApplication.MusteriGiris.Bussiness
{

    public class MusteriGirisBuss
    {

         #region InsertDeneme

        public void InsertDeneme(string Ad, string Soyad, long? TcNo, DateTime? DogumTarihi, string Yas, string Adres, string Cinsiyet, long? TelNo, string Email, string MusteriCinsiKodu, long? UyrukKodu, long? CografiBolgeKodu, long? SubeKodu)
        {
            string sql = @"INSERT into MUSTERILER(AD,SOYAD,TC_NO,DOGUM_TARIHI,YAS,CINSIYET,ADRES,TEL_NO,E-MAIL,MUSTERI_CINSI_KODU,UYRUK_KODU,COGRAFİ_BÖLGE_KODU,SUBE_KODU)
                                                  values (@pAd,@pSoyad,@pTcNo,@pDogumTarihi,@pYas,@pCinsiyet,@pAdres,@pTelNo,@pEmail,@pMusteriCinsiKodu,@pUyrukKodu,@pCografiBolgeKodu,@pSubeKodu)";

            MySqlParameter[] prms = 
              {
                  new MySqlParameter("@pAd", Ad),
                  new MySqlParameter("@pSoyad", Soyad),
                  new MySqlParameter("@pTcNo",TcNo),
                  new MySqlParameter("@pDogumTarihi",DogumTarihi),
                  new MySqlParameter("@pYas",Yas),
                  new MySqlParameter("@pAdres",Adres),
                  new MySqlParameter("@Cinsiyet",Cinsiyet),
                  new MySqlParameter("@TelNo",TelNo),
                  new MySqlParameter("@Email",Email),
                  new MySqlParameter("@pMusteriCinsiKodu",MusteriCinsiKodu),
                  new MySqlParameter("@pUyrukKodu",UyrukKodu),
                  new MySqlParameter("@pCografiBolgeKodu",CografiBolgeKodu),
                  new MySqlParameter("@pSubeKodu",SubeKodu)

              };

            using (DbManager dbMan = new DbManager())
            {
                int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prms);
                if (etkilenenKayitSayisi == 0)
                {
                    throw new Exception("İşlem gerçekleştirilemedi.");
                }

            }

        }
 
	    #endregion         

        /// <summary>
        /// Sql tablolarına inset,update,delete işlemleri buradan yapılıyor.
        /// </summary>
        public bool MusteriInsert(Musteri mstr)
        {
            //Bağlantı açıldığında çalıştırılacak insert komutu.
            string sql = @"INSERT into BankAplication.dbo.MUSTERILER(HESAP_NO,AD,SOYAD,TC_NO,DOGUM_TARIHI,YAS,CINSIYET,ADRESI,TEL_NO,[E_MAIL],MUSTERI_CINSI_KODU,UYRUK_KODU,COGRAFİ_BÖLGE_KODU,SUBE_KODU)
                                                values (next value for seqHesapNo,@pAd,@pSoyad,@pTcNo,@pDogumTarihi,@pYas,@pCinsiyet,@pAdres,@pTelNo,@pEmail,@pMusteriCinsiKodu,@pUyrukKodu,@pCografiBolgeKodu,@pSubeKodu)";

            MySqlParameter[] prms = 
            {
                new MySqlParameter("@pAd", mstr.Ad),
                new MySqlParameter("@pSoyad", mstr.Soyad),
                new MySqlParameter("@pTcNo",mstr.TcNo),
                new MySqlParameter("@pDogumTarihi",mstr.DogumTarihi),
                new MySqlParameter("@pYas",mstr.Yas),
                new MySqlParameter("@pAdres",mstr.Adres),
                new MySqlParameter("@pCinsiyet",mstr.Cinsiyet),
                new MySqlParameter("@pTelNo",mstr.TelNo),
                new MySqlParameter("@pEmail",mstr.Email),
                new MySqlParameter("@pMusteriCinsiKodu",mstr.MusteriCinsiKodu),
                new MySqlParameter("@pUyrukKodu",mstr.UyrukKodu),
                new MySqlParameter("@pCografiBolgeKodu",mstr.CografiBolgeKodu),
                new MySqlParameter("@pSubeKodu",mstr.SubeKodu)

            };
            using (DbManager dbMan = new DbManager())
            {
                int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prms);
                return etkilenenKayitSayisi > 0;
            }
        }

        /// <summary>
        /// Müsteri bilgilerini HesapNo ile Sorgulama yapan method
        /// </summary>
        public Musteri MusteriSorgula(long? hesapNo)
        { 
            string sql = @"select * from BankAplication.dbo.MUSTERILER
                            where HESAP_NO = @pHesapNo"; // Sorgulama komutu

            MySqlParameter prm = new MySqlParameter("@pHesapNo", hesapNo);

            using (DbManager dbMan = new DbManager())
            {

                DataTable dt = dbMan.BilgiGetir(sql, prm);

                if (dt.Rows.Count > 0)
                {
                    DataRow mstrRow = dt.Rows[0];
                    Musteri ms = new Musteri(mstrRow);
                    return ms;

                }
                else
                {
                    throw new Exception(hesapNo.ToString() + " numaralı müşteri bulunamadı.");
                }

            }

        }

        /// <summary>
        /// Müsteri bilgilerini HesapNo ile Sorgulama yaptıktan sonra silme işlemi yapan metod
        /// </summary>
        public bool MusteriSil(long? hesapNo)
        {
            string sql = @"DELETE FROM BankAplication.dbo.MUSTERILER
                            WHERE HESAP_NO = @pHesapNo"; // Sorgulama komutu

            MySqlParameter prm = new MySqlParameter("@pHesapNo", hesapNo);

            using (DbManager dbMan = new DbManager())
            {

                int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prm);

                return etkilenenKayitSayisi == 0 ? false : true; 

            }

        }

        public bool MusteriGuncelle(Musteri mus)
        {

            string sql = @"update BankAplication.dbo.MUSTERILER
                              set AD=@pAd,
                                  SOYAD=@pSoyad,
                                  TC_NO=@pTcNo,
                                  DOGUM_TARIHI=@pDogumTarihi,
                                  YAS=@pYas,
                                  CINSIYET=@pCinsiyet,
                                  ADRESI=@pAdres,
                                  TEL_NO=@pTelNo,
                                  [E_MAIL]=@pEmail,
                                  MUSTERI_CINSI_KODU=@pMusteriCinsiKodu,
                                  UYRUK_KODU=@pUyrukKodu,
                                  COGRAFİ_BÖLGE_KODU=@pCografiBolgeKodu,
                                  SUBE_KODU=@pSubeKodu
                            where HESAP_NO =@pHesapNo";
            MySqlParameter[] prms = 
            {
                new MySqlParameter("@pAd", mus.Ad),
                new MySqlParameter("@pSoyad", mus.Soyad),
                new MySqlParameter("@pTcNo",mus.TcNo),
                new MySqlParameter("@pDogumTarihi",mus.DogumTarihi),
                new MySqlParameter("@pYas",mus.Yas),
                new MySqlParameter("@pAdres",mus.Adres),
                new MySqlParameter("@pCinsiyet",mus.Cinsiyet),
                new MySqlParameter("@pTelNo",mus.TelNo),
                new MySqlParameter("@pEmail",mus.Email),
                new MySqlParameter("@pMusteriCinsiKodu",mus.MusteriCinsiKodu),
                new MySqlParameter("@pUyrukKodu",mus.UyrukKodu),
                new MySqlParameter("@pCografiBolgeKodu",mus.CografiBolgeKodu),
                new MySqlParameter("@pSubeKodu",mus.SubeKodu),
                new MySqlParameter("@pHesapNo",mus.HesapNo)
            };

            using (DbManager dbMan = new DbManager())
            {
                int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prms);
                return etkilenenKayitSayisi > 0;
            }

        }

        public DataTable SubeleriGetir()
        {
            string sql = @"select SUBE_KODU,SUBE_ADI from SUBELER";
            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }

        public DataTable UyrukBilgisiGetir() 
        {
            string sql = @"select UYRUK_KODU,UYRUK_ADI from UYRUK";
            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }

        public DataTable MüsteriCinsiBilgisiGetir()
        {
            string sql = @"select MUSTERI_CINSI_KODU,MUSTERI_CINSI_ADI from MUSTERI_CINSI";
            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }

        public DataTable CografiBölgeBilgisiGetir()
        {
            string sql = @"select COGRAFI_BOLGE_KODU,COGRAFI_BOLGE_ADI from COGRAFI_BOLGE";
            using(DbManager dbMan=new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }
        
    }
}


