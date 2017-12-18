using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BankApplication.Framework.BussHelper;


namespace BankApplication.KullaniciGirisi.Bussiness
{
    public class KullaniciGirisBuss
    { 
        public KullaniciGirisLib KullaniciSorgula(string KullaniciAd, string KullaniciSifre)
        {

            string sql = @"select * from BankAplication.dbo.KULLANICI
                            where KULLANICI_ADI = @pKullaniciAd
                              and KULLANICI_SIFRE=@pKullaniciSifre";

            MySqlParameter[] prm = 
            {
                new MySqlParameter("@pKullaniciAd",KullaniciAd),
                new MySqlParameter("@pKullaniciSifre",KullaniciSifre)
            };
            using (DbManager dbMan = new DbManager())
            {

                DataTable dt = dbMan.BilgiGetir(sql, prm);

                if (dt.Rows.Count > 0)
                {
                    DataRow klnRow = dt.Rows[0];
                    KullaniciGirisLib kl = new KullaniciGirisLib(klnRow);
                    return kl;

                }
                else 
                {
                    throw new Exception("Veritabaninda boyle bir kullanici Bulunamadi");
                    
                }



            }


        }

    }
}
