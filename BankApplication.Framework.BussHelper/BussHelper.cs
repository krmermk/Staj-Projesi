using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BankApplication.Framework.BussHelper
{
    public class BussHelper
    {

        public DataTable ButunDovizKodlariGetir()
        {
            string sql = @"select DVZ_KOD,DVZ_ADI,DVZ_CINS from DOVIZ";

            using (DbManager dbMan = new DbManager())
            {
                return dbMan.BilgiGetir(sql);
            }
        }

    }
}

