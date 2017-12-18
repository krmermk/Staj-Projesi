using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.EkHesap.Bussiness
{
    
    public class EkLib
    {
       public long? HesapNo { set; get; }
       public long? SubeKodu { set; get; }
       public long? EkNo { set; get; }
       public decimal? Bakiye { set; get; }
       public long? DövizKodu { set; get; }

        public EkLib()
        {

        }

        public EkLib(DataRow mstr)
        {
            HesapNo = ConvertHelper.ConvertTo<long>(mstr["HESAP_NO"]);
            SubeKodu = ConvertHelper.ConvertTo<long>(mstr["SUBE_KODU"]);
            EkNo = ConvertHelper.ConvertTo<long>(mstr["EK_NO"]);
            Bakiye = ConvertHelper.ConvertTo<decimal>(mstr["BAKİYE"]);
            DövizKodu = ConvertHelper.ConvertTo<long>(mstr["DVZ_KODU"]);
        }

        public bool ZorunlulukKontrol()
        {
            StringBuilder strMesaj = new StringBuilder();

            if (!DövizKodu.HasValue)
            {
                strMesaj.AppendLine("Döviz bilgisini giriniz.");
            }

            if (!HesapNo.HasValue)
            {
                throw new Exception("HesapNo bilgisini giriniz.");
            }

            if (!SubeKodu.HasValue)
            {
                throw new Exception("SubeNo bilgisini giriniz.");
            }

            if (!Bakiye.HasValue)
            {
                throw new Exception("Bakiye bilgisini giriniz.");
            }

            if (!string.IsNullOrEmpty(strMesaj.ToString()))
                throw new Exception(strMesaj.ToString());
            return true;
        }
    }
}
