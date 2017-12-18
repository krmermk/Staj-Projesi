using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.ParaAktarma.business
{
    public class ParaAktarmaLib
    {
        public long? GonderenHesapNo { set; get; }
        public long? AlanHesapNo { set; get; }
        public long? GönderenEkNo { set; get; }
        public long? AlnanEkNo { set; get; }
        public decimal? Tutar { set; get; }
        public DateTime? IslamTarihi { set; get; }
        public long? GönderenDvzKod { set; get; }
        public long? AlanDvzKod { set; get; }
        public decimal? Kur { set; get; }
        
        
        public ParaAktarmaLib()
        {

        }

        public ParaAktarmaLib(DataRow mstr)
        {
            GonderenHesapNo = ConvertHelper.ConvertTo<long>(mstr["GONDEREN_HESAP_NO"]);
            Kur = ConvertHelper.ConvertTo<long?>(mstr["KUR"]);
            AlanHesapNo = ConvertHelper.ConvertTo<long>(mstr["ALAN_HESAP_NO"]);
            GönderenEkNo = ConvertHelper.ConvertTo<long>(mstr["GONDEREN_EK_NO"]);
            AlnanEkNo = ConvertHelper.ConvertTo<long>(mstr["ALAN_EK_NO"]);
            Tutar = ConvertHelper.ConvertTo<decimal?>(mstr["TUTAR"]);
            IslamTarihi = ConvertHelper.ConvertTo<DateTime?>(mstr["ISLEM_TARIHI"]);
            GönderenDvzKod = ConvertHelper.ConvertTo<long?>(mstr["GONDEREN_DVZ_KOD"]);
            AlanDvzKod = ConvertHelper.ConvertTo<long?>(mstr["ALAN_DVZ_KOD"]);
         

        }

        public bool ZorunlulukKontrol()
        {
            StringBuilder strMesaj = new StringBuilder();

            if (!GonderenHesapNo.HasValue)
            {
                throw new Exception("Gönderen HesapNo bilgisini giriniz.");
            }
            if (!AlanHesapNo.HasValue)
            {
                throw new Exception("Alıcı HesapNo bilgisini giriniz.");
            }

            if (!Tutar.HasValue)
            {
                throw new Exception("Tutar bilgisini giriniz.");
            }
            
            if (!string.IsNullOrEmpty(strMesaj.ToString()))
                throw new Exception(strMesaj.ToString());
            return true;

        }
    }
}
