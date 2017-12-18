using BankApplication.Framework.BussHelper;
using BankApplication.FrameWork.CommonHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace BankApplication.ParaAktarma.business
{
    public class ParaAktarmaBuss
    {

        public bool ParaAktarmaKAydet(ParaAktarmaLib Pr) 
        {
            using (DbManager dbMan = new DbManager())
            {
                if (Pr.GönderenDvzKod != Pr.AlanDvzKod)
                {
                   KurGetir(dbMan, Pr);
                }
                else
                {
                    Pr.Kur = 1;
                }

            string sqlUpdateAlanHesap = @"update BankAplication.dbo.HESAPLAR
                                                set BAKİYE=BAKİYE+(@pTutar*@pKur)
                                              WHERE HESAP_NO = @pAlanHesapNo
                                                and EK_NO=@pAlanEkNo";

            MySqlParameter[] prmsAlanHesap = 

                        {
                            new MySqlParameter("@pTutar",Pr.Tutar),
                            new MySqlParameter("@pAlanHesapNo",Pr.AlanHesapNo),
                            new MySqlParameter("@pAlanEkNo",Pr.AlnanEkNo),
                            new MySqlParameter("@pKur",Pr.Kur)
                        };


            // Para Gönderen Hesap
            string sqlUpdateGonderenHesap = @"update BankAplication.dbo.HESAPLAR
                                                        set BAKİYE=BAKİYE-@pTutar
                                                      WHERE HESAP_NO = @pGonderenHesapNo
                                                        and EK_NO=@pGönderenEkNo";


            MySqlParameter[] prmsGonderenHesap = 
                        {
                                new MySqlParameter("@pTutar",Pr.Tutar),
                                new MySqlParameter("@pGonderenHesapNo",Pr.GonderenHesapNo),
                                new MySqlParameter("@pGönderenEkNo",Pr.GönderenEkNo)
                            };
            string sql = @"INSERT into BankAplication.dbo.TRANSFER(GONDEREN_HESAP_NO,ALAN_HESAP_NO,GONDEREN_EK_NO,ALAN_EK_NO,GONDEREN_DVZ_KOD,ALAN_DVZ_KOD,TUTAR,KUR,ISLEM_TARIHI)
                                                            values (@pGonderenHesapNo,@pAlanHesapNo,@pGönderenEkNo,@pAlanEkNo,@pGönderenDvzKod,@pAlanDvzKod,@pTutar,@pKur,getdate())";
            MySqlParameter[] prms =
            {
                new MySqlParameter("@pGonderenHesapNo",Pr.GonderenHesapNo),
                new MySqlParameter("@pAlanHesapNo",Pr.AlanHesapNo),
                new MySqlParameter("@pGönderenEkNo",Pr.GönderenEkNo),
                new MySqlParameter("@pAlanEkNo",Pr.AlnanEkNo),
                new MySqlParameter("@pTutar",Pr.Tutar),
                new MySqlParameter("@pGönderenDvzKod",Pr.GönderenDvzKod),
                new MySqlParameter("@pAlanDvzKod",Pr.AlanDvzKod),
                new MySqlParameter("@pKur",Pr.Kur)
            };
            

                  int etkilenenKayitSayisi1 = dbMan.DmlCalistir(sqlUpdateGonderenHesap, prmsGonderenHesap);

                  int    etkilenenKayitSayisi2 = dbMan.DmlCalistir(sqlUpdateAlanHesap, prmsAlanHesap);

                  int etkilenenKayitSayisi3 = dbMan.DmlCalistir(sql, prms);

                  return etkilenenKayitSayisi1 == 1 && etkilenenKayitSayisi2 == 1 && etkilenenKayitSayisi3 == 1;
            }

  
        }

        private void KurGetir(DbManager dbMan, ParaAktarmaLib Pr)
        {
            
                string sql = @"select KUR
                           from KURLAR
                           where DVZ_KODU=@pGönderenDvzKod
                             and CEVRILECEK_DVZ_KODU=@pAlanDvzKod
                             and TARIH=cast (getdate() as date ) ";

                MySqlParameter[] prms = 
                        {
                            new MySqlParameter("@pGönderenDvzKod",Pr.GönderenDvzKod),
                            new MySqlParameter("@pAlanDvzKod",Pr.AlanDvzKod)
                        };
                DataTable dtKur = dbMan.BilgiGetir(sql, prms);
                decimal? kur = ConvertHelper.ConvertTo<decimal?>(dtKur.Rows[0]["KUR"]);
                Pr.Kur = kur;

        }

        public DataTable ParaAktarımSorgulama(long? HesapNoAktaran, long? HesapNoAktarilan, ref DataTable dtAktarilanHesapBilgi)
        {
            string sql = @"select HESAP_NO,h.SUBE_KODU,EK_NO,BAKİYE,h.DVZ_KODU,d.DVZ_ADI,s.SUBE_ADI
                             from BankAplication.dbo.HESAPLAR h,DOVIZLER d,SUBELER s
                             where HESAP_NO =@pHesapNo                                
                                 and h.DVZ_KODU  = d.DVZ_KODU
                                 and h.SUBE_KODU = s.SUBE_KODU";

            MySqlParameter prmAktaran = new MySqlParameter("@pHesapNo", HesapNoAktaran);
            MySqlParameter prmAktarilan = new MySqlParameter("@pHesapNo", HesapNoAktarilan);

            using (DbManager dbMan = new DbManager())
            {
                DataTable dtAktaran = dbMan.BilgiGetir(sql, prmAktaran);
                dtAktarilanHesapBilgi = dbMan.BilgiGetir(sql, prmAktarilan);
                return dtAktaran;
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

        public DataTable DovizleriGetir()
        {
            string sql = @"select DVZ_KODU,DVZ_ADI from DOVIZLER";

            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }
        
    }
}