using BankApplication.Framework.FrmHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankApplication.EkHesap.Bussiness;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.EkHesap.Forms
{
    #region Buton Foksiyonları
    
   
    public partial class EkHesapGiris : BaseForm
    {
        EkHesapGirisBuss _buss;

        public EkHesapGiris()
        {
            InitializeComponent();
        }

        

        private void EkHesapGiris_Load(object sender, EventArgs e)
        {
            _buss = new EkHesapGirisBuss();
            SetIslemMode( IslemMod.Baslangic);
            EkranDisable();

            DataTable dtSubeler = _buss.SubeleriGetir();

            long? subeKod;
            string subeAdi;
            long? DovizKod;
            string DovizAdi;


            foreach (DataRow rowSube in dtSubeler.Rows)
            {
                subeKod = ConvertHelper.ConvertTo<long?>(rowSube["SUBE_KODU"]);
                subeAdi = rowSube["SUBE_ADI"].ToString();

                ucComboBoxSbKd.DegerEkle(subeKod, subeAdi);
            }
            DataTable dtDoviz = _buss.DovizleriGetir();

            foreach (DataRow rowDoviz in dtDoviz.Rows)
            {
                DovizKod = ConvertHelper.ConvertTo<long?>(rowDoviz["DVZ_KODU"]);
                DovizAdi = rowDoviz["DVZ_ADI"].ToString();
               ucComboBoxDvzKd.DegerEkle(DovizKod, DovizAdi);
            }

        }

        private void EkranDisable() 
        {
            groupBoxEkHspBlglr.Enabled = false;
            groupBoxSorgulama.Enabled = false;
        }

        private void EkranTemizle() 
        {
            GroupBoxTemizle(groupBoxSorgulama);
            GroupBoxTemizle(groupBoxEkHspBlglr);
            GroupBoxTemizle(groupBoxDtGrdvw);
            
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Yeni);
            groupBoxSorgulama.Enabled=true;
            buttonSorgula.Enabled = true;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Sil);
            groupBoxSorgulama.Enabled = true;
        }

        private void buttonDüzelt_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Düzelt);
            groupBoxSorgulama.Enabled = true;
  
        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ucSayiGirisHesapNo.Deger.HasValue)
                {
                    MessageBox.Show("Müsteri Hesap No Bos Girdiniz");
                    return;
                }
                    

               else if (!_buss.MusteriVarMi(ucSayiGirisHesapNo.Deger))
                {
                    MessageBox.Show("Girilen hesaba ait müşteri mevcut değildir.Müşteri Giris ekranından yeni müşteri tanımlayınız.");
                    return;
                }

                ucSayiGirisEkNo.Deger = _buss.SiradakiEkNoGetir(ucSayiGirisHesapNo.Deger);



                DataTable tablo = _buss.EkGridSorgula(ucSayiGirisHesapNo.Deger);
                dataGridViewEkHspGrs.DataSource = tablo;

              if (_aktifIslemMod == IslemMod.Yeni)
                {
                    groupBoxEkHspBlglr.Enabled = true;
                }
                    buttonSorgula.Enabled = false;
                    buttonKaydet.Enabled = true;
                    buttonVazgec.Enabled = true;
                    groupBoxSorgulama.Enabled = false;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                DataTable tablo = _buss.EkGridSorgula(ucSayiGirisHesapNo.Deger);
                dataGridViewEkHspGrs.DataSource = tablo;

                if (_aktifIslemMod == IslemMod.Düzelt)
                    {
                        groupBoxEkHspBlglr.Enabled = true;
                    }
                        buttonKaydet.Enabled = true;
                        buttonVazgec.Enabled = true;
                        groupBoxSorgulama.Enabled = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (_aktifIslemMod == IslemMod.Yeni)
            {
                YeniKaydet();
            }
            else if (_aktifIslemMod == IslemMod.Düzelt)
            {
                EkHesapGüncelleKaydet();
            }
            if (_aktifIslemMod == IslemMod.Sil)
            {
                SilKaydet();
            }
            EkranTemizle();
        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Baslangic);
            EkranTemizle();
            EkranDisable();

        }

        private void YeniKaydet()
        {
            EkLib ekNesne = EkrandanBilgiGetir();
            if (ekNesne.ZorunlulukKontrol())
            {
                bool ekIslemSonuc = _buss.EkHesapGirisInsert(ekNesne);

                if (ekIslemSonuc)
                {
                    MessageBox.Show("Başarılı işlem");
                    SetIslemMode(IslemMod.Baslangic);
                    groupBoxEkHspBlglr.Enabled = false;
                    EkranTemizle();
                    EkranDisable();

                }

                else
                {
                    MessageBox.Show("Başarsız işlem ");
                }

            }

        }

        private void SilKaydet() 
        {
            bool islemSonuc = _buss.EkHesapSil(ucSayiGirisHesapNo.Deger,ucSayiGirisEkNo.Deger);

            if (islemSonuc)
            {
                MessageBox.Show("Ek Hesap Silme İşlemi Başarılı");
                SetIslemMode(IslemMod.Baslangic);
                EkranDisable();
            }
            else 
            {
                MessageBox.Show("Ek Hesap Silme İşlemi Başarısız");
            }
        }

        private void EkHesapGüncelleKaydet() 
        {
            EkLib ek = EkrandanBilgiGetir();
            if (ek.ZorunlulukKontrol())
            {
                bool islemSonuc = _buss.EkHesapGüncelle(ek);
                if (islemSonuc)
                {
                    MessageBox.Show("Ek Hesap Güncelleme İşlemi Başarılı");
                    SetIslemMode(IslemMod.Baslangic);
                    EkranDisable();
                }
                else
                {
                    MessageBox.Show("Ek Hesap Güncelleme İşlemi Başarısız ");
                }
            }
 
        }

        private EkLib EkrandanBilgiGetir()
        {
            EkLib ekNesne = new EkLib();
            ekNesne.SubeKodu = ucComboBoxSbKd.XSecilenKeyTolong;
            ekNesne.EkNo = ucSayiGirisEkNo.Deger;
            ekNesne.DövizKodu = ucComboBoxDvzKd.XSecilenKeyTolong;
            ekNesne.HesapNo = ucSayiGirisHesapNo.Deger;
            ekNesne.Bakiye = ucTutarGirisBky.Deger;
            
            return ekNesne;
        }

        private void dataGridViewEkHspGrs_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridViewEkHspGrs.DataSource != null)
            {
                dataGridViewEkHspGrs.Columns["DVZ_KODU"].Visible = false;
                dataGridViewEkHspGrs.Columns["SUBE_KODU"].Visible = false;
                dataGridViewEkHspGrs.Columns["DVZ_ADI"].HeaderText = "Döviz Adi";
                dataGridViewEkHspGrs.Columns["HESAP_NO"].HeaderText = "Hesap No";
                dataGridViewEkHspGrs.Columns["BAKİYE"].HeaderText = "Bakiye";
                dataGridViewEkHspGrs.Columns["EK_NO"].HeaderText = "Ek No";
                dataGridViewEkHspGrs.Columns["SUBE_ADI"].HeaderText = "Şube Adı";
            }
        }

        private void dataGridViewEkHspGrs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && _aktifIslemMod != IslemMod.Yeni) 
            {
                ucTutarGirisBky.Deger = ConvertHelper.ConvertTo<decimal?>(dataGridViewEkHspGrs.Rows[e.RowIndex].Cells["BAKİYE"].Value);
                ucComboBoxDvzKd.XSecilenKey = ConvertHelper.ConvertTo<long?>(dataGridViewEkHspGrs.Rows[e.RowIndex].Cells["DVZ_KODU"].Value);
                ucSayiGirisEkNo.Deger = ConvertHelper.ConvertTo<long?>(dataGridViewEkHspGrs.Rows[e.RowIndex].Cells["EK_NO"].Value);
                ucComboBoxSbKd.XSecilenKey = ConvertHelper.ConvertTo<long?>(dataGridViewEkHspGrs.Rows[e.RowIndex].Cells["SUBE_KODU"].Value);
            }

        }

       

    }
    #endregion
}
    