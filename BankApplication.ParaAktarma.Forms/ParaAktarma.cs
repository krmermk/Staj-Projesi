using BankApplication.Framework.FrmHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankApplication.ParaAktarma.business;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.ParaAktarma.Forms
{
    public partial class ParaAktarma : BaseForm
    {
        ParaAktarmaBuss _buss1;

        public ParaAktarma()
        {
            InitializeComponent();
            dataGridViewParaGndrnnBlglr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPralnnBlglr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void EkranDisable()
        {
            groupBoxPrAktrnHsp.Enabled= false;
            groupBoxParaAktarlnHsp.Enabled = false;
            groupBoxTtrGrs.Enabled = false;
        }

        private void EkranTemizle()
        {
            GroupBoxTemizle(groupBoxPrAktrnHsp);
            GroupBoxTemizle(groupBoxParaAktarlnHsp);
            GroupBoxTemizle(groupBoxTtrGrs);
            GroupBoxTemizle(groupBoxDtgrdPrAktrm);
        }

        private void ParaAktarma_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            groupBoxPrAktrnHsp.Enabled = true;
            groupBoxParaAktarlnHsp.Enabled = true;
            buttonSorgula.Enabled = true;
        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ucSayiGirisGönderenHesapNo.Deger.HasValue && !ucSayiGirisAlanHesapNo.Deger.HasValue) 
                {
                    MessageBox.Show("Gönderen Hesapno'sunu  ve Alan Hesapno'sunu girmediniz. Lütfen hesapnoları girdikten sonra tekra sorgulama yapın");
                    return;
                }
  
                _buss1 = new ParaAktarmaBuss();

                DataTable dtAlanHesapBilgi = new DataTable();
                DataTable tablo = _buss1.ParaAktarımSorgulama(ucSayiGirisGönderenHesapNo.Deger, ucSayiGirisAlanHesapNo.Deger, ref dtAlanHesapBilgi);
                dataGridViewParaGndrnnBlglr.DataSource = tablo;
                dataGridViewPralnnBlglr.DataSource = dtAlanHesapBilgi;



                if (_aktifIslemMod == IslemMod.Yeni)
                {
                    groupBoxPrAktrnHsp.Enabled = true;
                    groupBoxParaAktarlnHsp.Enabled = true;

                }
                buttonSorgula.Enabled = true;
                buttonKaydet.Enabled = true;
                buttonVazgec.Enabled = true;
                groupBoxTtrGrs.Enabled = true;

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
           

            }        

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

            ParaAktarmaLib PrNesne = EkrandanBilgiGetir();
            if (PrNesne.ZorunlulukKontrol())
            {
                bool ekIslemSonuc = _buss1.ParaAktarmaKAydet(PrNesne);
                if (ekIslemSonuc)
                {
                    MessageBox.Show("Başarılı işlem");
                    SetIslemMode(IslemMod.Baslangic);
                    groupBoxParaAktarlnHsp.Enabled = false;
                    groupBoxTtrGrs.Enabled = false;
                    groupBoxPrAktrnHsp.Enabled = false;
                    EkranTemizle();

                }

                else
                {
                    MessageBox.Show("Başarsız işlem ");
                }
            }
            
              

        }
       
        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Baslangic);
            EkranTemizle();
            EkranDisable();
        }

        private ParaAktarmaLib EkrandanBilgiGetir()
        {
            ParaAktarmaLib PrNesne = new ParaAktarmaLib();
            PrNesne.GonderenHesapNo = ucSayiGirisGönderenHesapNo.Deger;
            PrNesne.AlanHesapNo = ucSayiGirisAlanHesapNo.Deger;
            PrNesne.GönderenEkNo = ucSayiGirisGönderenEkNo.Deger;
            PrNesne.AlnanEkNo = ucSayiGirisAlanEkNo.Deger;
            PrNesne.Tutar = ucTutarGirisTutar.Deger;
            PrNesne.GönderenDvzKod = ConvertHelper.ConvertTo<long?>(dataGridViewParaGndrnnBlglr.SelectedRows[0].Cells["DVZ_KODU"].Value);
            PrNesne.AlanDvzKod = ConvertHelper.ConvertTo<long?>(dataGridViewPralnnBlglr.SelectedRows[0].Cells["DVZ_KODU"].Value);

            return PrNesne;
        }

        private void dataGridViewParaGndrnnBlglr_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridViewParaGndrnnBlglr.DataSource != null)
            {
                dataGridViewParaGndrnnBlglr.Columns["DVZ_KODU"].Visible = false;
                dataGridViewParaGndrnnBlglr.Columns["SUBE_KODU"].Visible = false;
                dataGridViewParaGndrnnBlglr.Columns["DVZ_ADI"].HeaderText = "Döviz Adi";
                dataGridViewParaGndrnnBlglr.Columns["HESAP_NO"].HeaderText = "Hesap No";
                dataGridViewParaGndrnnBlglr.Columns["BAKİYE"].HeaderText = "Bakiye";
                dataGridViewParaGndrnnBlglr.Columns["EK_NO"].HeaderText = "Ek No";
                dataGridViewParaGndrnnBlglr.Columns["SUBE_ADI"].HeaderText = "Şube Adı";
            }
        }

        private void dataGridViewParaGndrnnBlglr_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && _aktifIslemMod != IslemMod.Yeni)
            {
                ucSayiGirisGönderenEkNo.Deger = ConvertHelper.ConvertTo<long?>(dataGridViewParaGndrnnBlglr.Rows[e.RowIndex].Cells["EK_NO"].Value);
            }
        }

        private void dataGridViewPralnnBlglr_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridViewPralnnBlglr.DataSource != null)
            {
                dataGridViewPralnnBlglr.Columns["DVZ_KODU"].Visible = false;
                dataGridViewPralnnBlglr.Columns["SUBE_KODU"].Visible = false;
                dataGridViewPralnnBlglr.Columns["DVZ_ADI"].HeaderText = "Döviz Adi";
                dataGridViewPralnnBlglr.Columns["HESAP_NO"].HeaderText = "Hesap No";
                dataGridViewPralnnBlglr.Columns["BAKİYE"].HeaderText = "Bakiye";
                dataGridViewPralnnBlglr.Columns["EK_NO"].HeaderText = "Ek No";
                dataGridViewPralnnBlglr.Columns["SUBE_ADI"].HeaderText = "Şube Adı";
            }
            
        }

        private void dataGridViewPralnnBlglr_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && _aktifIslemMod != IslemMod.Yeni)
            {

                ucSayiGirisAlanEkNo.Deger = ConvertHelper.ConvertTo<long?>(dataGridViewPralnnBlglr.Rows[e.RowIndex].Cells["EK_NO"].Value);
            }
        }

    }
}
