using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication.FrameWork.CommonHelper
{
    /// <summary>
    /// dbnull değerleri çevirirken convert hataları oluştuğundan dolayı convert işlemi yapmak üzere bu class yazıldı.
    /// </summary>
    public class ConvertHelper
    {
        private static long? ToLong(object deger)
        {
            return Convert.ToInt64(deger == DBNull.Value ? null : deger);
        }

        private static DateTime? ToDateTime(object deger)
        {
            return Convert.ToDateTime(deger == DBNull.Value ? null : deger);
        }

        private static int? ToInt(object deger)
        {
            return Convert.ToInt32(deger == DBNull.Value ? null : deger);
        }

        private static decimal? ToDecimal(object deger)
        {
            return Convert.ToDecimal(deger == DBNull.Value ? null : deger);
        }

        /// <summary>
        /// parametre olatak verilen değeri T yerine yazılan tipe dönüştürür.
        /// </summary>
        /// <typeparam name="T">dönüştürülmek istenen tip</typeparam>
        /// <param name="deger"></param>
        /// <returns></returns>
        public static T ConvertTo<T>(object deger)
        {
            T result;
            var tip = typeof(T);

            if (typeof(T).Name == "Nullable`1")
            {
                if (deger == DBNull.Value || deger == null)
                {
                    deger = null;
                    result = (T)deger;
                    return result;
                }
                if (tip == typeof(DateTime?))
                {
                    tip = typeof(DateTime);
                }
                else if (tip == typeof(long?))
                {
                    tip = typeof(long);
                }
                else if (tip == typeof(int?))
                {
                    tip = typeof(int);
                }
                else if (tip == typeof(decimal?))
                {
                    tip = typeof(decimal);
                }
            }
            if (deger is IConvertible)
            {
                result = TipDegistir<T>(deger, tip);

            }
            else
            {
                object result2 = deger;
                if (tip == typeof(decimal))
                {
                    result2 = ToDecimal(deger);
                }
                if (tip == typeof(int))
                {
                    result2 = ToInt(deger);
                }
                if (tip == typeof(DateTime))
                {
                    result2 = ToDateTime(deger);
                }
                if (tip == typeof(long))
                {
                    result2 = ToLong(deger);
                }
                result = (T)result2;

            }

            return result;
        }

        private static T TipDegistir<T>(object deger, Type tip)
        {

            //TODO SORULACAK
            T result;
            if (tip == typeof(decimal))
            {
                result = (T)Convert.ChangeType(ToDecimal(deger), tip);
            }
            else if (tip == typeof(int))
            {
                result = (T)Convert.ChangeType(ToInt(deger), tip);
            }
            else if (tip == typeof(DateTime))
            {
                result = (T)Convert.ChangeType(ToDateTime(deger), tip);
            }
            else if (tip == typeof(long))
            {
                result = (T)Convert.ChangeType(ToLong(deger), tip);
            }
            else
            {
                result = (T)deger;
            }
            return result;
        }

        

    }
}
