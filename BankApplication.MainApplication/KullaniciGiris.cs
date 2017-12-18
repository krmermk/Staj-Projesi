using BankApplication.Framework.BussHelper;
using BankApplication.KullaniciGirisi.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApplication.MainApplication
{
    public partial class KullaniciGiris : Form
    {
        KullaniciGirisBuss _buss = new KullaniciGirisBuss();

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                KullaniciGirisLib klnc = _buss.KullaniciSorgula(textBoxKllancAd.Text, textBoxKllncSfr.Text);
                FrmMain giris = new FrmMain();
                this.Hide();
                giris.ShowDialog();
                this.Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                 

        }

            
    }
}

