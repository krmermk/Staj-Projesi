using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApplication.Framework.BussHelper;
using System.Data;
using System.Data.SqlClient;
using BankApplication.FrameWork.CommonHelper;


namespace BankApplication.EkHesap.Bussiness
{
    public class EkHesapGirisBuss
    {
        public bool EkHesapGirisInsert(EkLib Ek) 
        {
            string sql = @"INSERT into BankAplication.dbo.HESAPLAR(HESAP_NO,SUBE_KODU,EK_NO,BAKİYE,DVZ_KODU)
                                                values (@pHesapNo,@pSubeKodu,@pEkNo,@pBakiye,@pDvzKodu)";
            Ek.EkNo = SiradakiEkNoGetir(Ek.HesapNo);
            MySqlParameter[] prms = 
            {
                new MySqlParameter("@pHesapNo",Ek.HesapNo),
                new MySqlParameter("@pSubeKodu", Ek.SubeKodu),
                new MySqlParameter("@pEkNo", Ek.EkNo), 
                new MySqlParameter("@pBakiye", Ek.Bakiye),
                new MySqlParameter("@pDvzKodu", Ek.DövizKodu),

            };

            using (DbManager dbMan = new DbManager())
            {
                int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prms);
                return etkilenenKayitSayisi > 0;
            }
        }

        public bool EkHesapSil(long? hesapNo,long? EkNo) 
        {
            string sql = @"DELETE FROM BankAplication.dbo.HESAPLAR
                            WHERE HESAP_NO = @pHesapNo
                                  and EK_NO=@pEkNo";
            MySqlParameter[] prms =
            {
               new MySqlParameter("@pHesapNo",hesapNo),
               new MySqlParameter("@pEkNo",EkNo)
            };

            using (DbManager dbMan = new DbManager())
            {
                int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prms);
                return etkilenenKayitSayisi > 0;
            }
        }

        public bool EkHesapGüncelle(EkLib ek)
        {
            string sql = @"update BankAplication.dbo.HESAPLAR
                            set BAKİYE=@pBakiye,
	                            SUBE_KODU=@pSubeKodu,
	                            DVZ_KODU=@pDvzKodu
                          WHERE HESAP_NO = @pHesapNo
                            and EK_NO=@pEkNo";
          MySqlParameter[] prms = 
          {
              new MySqlParameter("@pBakiye",ek.Bakiye),
              new MySqlParameter("@pSubeKodu",ek.SubeKodu),
              new MySqlParameter("@pDvzKodu",ek.DövizKodu),
              new MySqlParameter("@pHesapNo",ek.HesapNo),
              new MySqlParameter("@pEkNo",ek.EkNo)
          };
          using (DbManager dbMan = new DbManager())
          {
              int etkilenenKayitSayisi = dbMan.DmlCalistir(sql, prms);
              return etkilenenKayitSayisi > 0;
          }
            
        }

        public DataTable EkGridSorgula(long? HesapNo) 
        {
            DataTable dt = new DataTable();
            string sql = @"select HESAP_NO,h.SUBE_KODU,EK_NO,BAKİYE,h.DVZ_KODU,d.DVZ_ADI,s.SUBE_ADI
                             from BankAplication.dbo.HESAPLAR h,DOVIZLER d,SUBELER s
                             where HESAP_NO =@pHesapNo
                             and h.DVZ_KODU  = d.DVZ_KODU
                             and h.SUBE_KODU = s.SUBE_KODU";
            MySqlParameter prm = new MySqlParameter("@pHesapNo", HesapNo);

            using (DbManager dbMan = new DbManager())
            {
                dt = dbMan.BilgiGetir(sql, prm);                
            }
            return dt;
        }

        public DataTable SubeleriGetir()
        {
            string sql = @"select SUBE_KODU,SUBE_ADI from SUBELER";
            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }

        public DataTable DovizleriGetir() 
        {
            string sql = @"select DVZ_KODU,DVZ_ADI from DOVIZLER";

            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }

        public long? SiradakiEkNoGetir(long? hesapNo)
        {
            string sql = @" select isnull (MAX(EK_NO),0) +1 SIRADAKI_EK_NO from HESAPLAR
                            where HESAP_NO = @pHesapNo ";
            MySqlParameter prm = new MySqlParameter("@pHesapNo", hesapNo);
            using (DbManager dbman = new DbManager())
            {
                DataTable dtEkNo = dbman.BilgiGetir(sql, prm);
                long? siradakiEkNo = ConvertHelper.ConvertTo<long?>(dtEkNo.Rows[0]["SIRADAKI_EK_NO"]);
                return siradakiEkNo;
            }
        }

        /// <summary>
        /// Girilen hesap noya ait müşteri olup olmadığını döner
        /// </summary>
        public bool MusteriVarMi(long? hesapNo)
        {
            string sql = @"select count(*) from BankAplication.dbo.MUSTERILER
                            where HESAP_NO = @pHesapNo";  

            MySqlParameter prm = new MySqlParameter("@pHesapNo", hesapNo);

            using (DbManager dbMan = new DbManager())
            {

                DataTable dt = dbMan.BilgiGetir(sql, prm);

                if (dt.Rows.Count > 0 && Convert.ToInt32( dt.Rows[0][0]) > 0)
                    return true;
                else
                    return false;

            }

        }

    }
}
