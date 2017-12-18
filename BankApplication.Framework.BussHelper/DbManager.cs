using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BankApplication.Framework.BussHelper
{
    public class DbManager : IDisposable 
    {
        SqlConnection _baglanti;
        
        /// <summary>
        /// Database bağlantıyı gerçekleştiren method.
        
        /// </summary>
        public DbManager()
        {
            _baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=BankAplication;Integrated Security=True");
            
        }
       
        /// <summary>
        /// sql koomutu sorgulama yaptıktan sonra bilgileri datatable doldurur.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable BilgiGetir(string sql) 
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, _baglanti);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tablo = new DataTable();
            adp.Fill(tablo);//Adabtördeki bilgileri tabloya ekler.

            return tablo;
        }

        /// <summary>
        /// Sql ve parametre sorguları datatable doldurur.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="prms"></param>
        /// <returns></returns>
        public DataTable BilgiGetir(string sql,params MySqlParameter[] prms)
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, _baglanti);
          
            foreach (var prm in prms)
            {
                cmd.Parameters.AddWithValue(prm.ParamName, prm.Value ?? DBNull.Value);
                
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable tablo = new DataTable();
            adp.Fill(tablo);

            return tablo;
        }

        public void Dispose() 
        {
            _baglanti.Close();
        }

        /// <summary>
        /// Dml işlemlerini çalıştırmak için sql query ve parametreleri alan ve işlemi gerçekleştiren method
        /// </summary>
        /// <param name="sql">Çalıştırılacak olan sql</param>
        /// <param name="prms">Sql de kullanılacak olan parametreler</param>
        /// <returns></returns>
        public int DmlCalistir(string sql, params MySqlParameter[] prms) 
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, _baglanti);

            foreach (var prm in prms)
            {
                cmd.Parameters.AddWithValue(prm.ParamName, prm.Value ?? DBNull.Value); 
            }

           return cmd.ExecuteNonQuery();
        }

    }

    /// <summary>
    /// SqlParameter oluşturulmasına izin verilmediği için ara bir class olarak oluşturuldu.
    /// Sqlparameter constructor internal olarak tanımlandığından dolayı nesne oluşturulamıyor.
    /// </summary>
    public class MySqlParameter 
    {
        public string ParamName { get;private set; }
        public object Value { get; private set; }

        public MySqlParameter(string paramName, object value)
        {
            this.ParamName = paramName;
            this.Value = value;
        }
    }

 }


