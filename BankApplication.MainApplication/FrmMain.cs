using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankApplication.EkHesap.Forms;
using BankApplication.ParaAktarma.Forms;
using BankApplication.MusteriGiris.Forms;

namespace BankApplication.MainApplication
{
    /// <summary>
    /// diğer ekranları açan ana ekran
    /// bu proje windows form application formatında oluşturulmuştur 
    /// diğer ekranlar bu ekran tarafından çağiralacagından dolayı class library şeklinde oluşturulmuştur.
    /// </summary>
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonMusteriGiris_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris giris = new FrmMusteriGiris();
            giris.ShowDialog();
        }

        private void buttonEkHesapGiris_Click(object sender, EventArgs e)
        {
            EkHesapGiris giris = new EkHesapGiris();
            giris.ShowDialog();
        }

        private void buttonPrAktrm_Click(object sender, EventArgs e)
        {
            BankApplication.ParaAktarma.Forms.ParaAktarma aktrm = new ParaAktarma.Forms.ParaAktarma();
            aktrm.ShowDialog();

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();

        }

        

    }
}
