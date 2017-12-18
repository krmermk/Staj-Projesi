using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankApplication.Framework.FrmHelper;
using BankApplication.MusteriGiris.Bussiness;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.MusteriGiris.Forms
{
    public partial class FrmMusteriGiris : BaseForm
    {
        MusteriGirisBuss _buss;

       public FrmMusteriGiris()
        {
            InitializeComponent();
        }

       private void MusteriGiris_Load(object sender, EventArgs e)
       {
           _buss = new MusteriGirisBuss();
           SetIslemMode(IslemMod.Baslangic);
           EkranDisable();
           ucComboBoxCinsiyet.DegerEkle("E", "Erkek");
           ucComboBoxCinsiyet.DegerEkle("K", "Kadın");

           DataTable dtSubeler = _buss.SubeleriGetir();
                long? subeKod;
               string subeAdi;

                 foreach (DataRow rowSube in dtSubeler.Rows)
                   {
                       subeKod = ConvertHelper.ConvertTo<long?>(rowSube["SUBE_KODU"]);
                        subeAdi = rowSube["SUBE_ADI"].ToString();

                        ucComboBoxSbkd.DegerEkle(subeKod, subeAdi);
                   }

                DataTable dtMusteriCinsi = _buss.MüsteriCinsiBilgisiGetir();
                    string MüsteriCinsiKod;
                    string MüsteriCinsiAdi;

                foreach (DataRow rowMusteriCinsi in dtMusteriCinsi.Rows)
	                {
                        MüsteriCinsiKod = rowMusteriCinsi["MUSTERI_CINSI_KODU"].ToString();
                        MüsteriCinsiAdi = rowMusteriCinsi["MUSTERI_CINSI_ADI"].ToString();
                        ucComboBoxMstrCsKd.DegerEkle(MüsteriCinsiKod,MüsteriCinsiAdi);
	                }

                DataTable dtUyruk = _buss.UyrukBilgisiGetir();
                    long? uyrukKod;
                   string uyrukAdi;

                foreach (DataRow rowUyruk in dtUyruk.Rows)
                {
                    uyrukKod = ConvertHelper.ConvertTo<long?>(rowUyruk["UYRUK_KODU"]);
                    uyrukAdi = rowUyruk["UYRUK_ADI"].ToString();
                    ucComboBoxUyrkKd.DegerEkle(uyrukKod, uyrukAdi);
                }

                DataTable dtCografi = _buss.CografiBölgeBilgisiGetir();
                    long? CografiBölgeKod;
                   string CografiBölgeAdi;

                foreach (DataRow rowCografi in dtCografi.Rows)
                {
                    CografiBölgeKod = ConvertHelper.ConvertTo<long?>(rowCografi["COGRAFI_BOLGE_KODU"]);
                    CografiBölgeAdi = rowCografi["COGRAFI_BOLGE_ADI"].ToString();
                    ucComboBoxCgrfBlgKd.DegerEkle(CografiBölgeKod, CografiBölgeAdi);
                }
       }

       private void EkranTemizle()
       {
           GroupBoxTemizle(groupBoxIltsmBlgs);
           GroupBoxTemizle(groupBoxGnlMstrBlgs);
           GroupBoxTemizle(groupBoxSbBlgs);
           GroupBoxTemizle(groupBoxSrglm);
       }

       /// <summary>
       /// ekranı kapama işlemi
       /// </summary>
       private void EkranDisable()
       {
           groupBoxGnlMstrBlgs.Enabled = false;
           groupBoxSbBlgs.Enabled = false;
           groupBoxIltsmBlgs.Enabled = false;
           groupBoxSrglm.Enabled = false;
       }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Yeni);
            groupBoxGnlMstrBlgs.Enabled = true;
            groupBoxSbBlgs.Enabled = true;
            groupBoxIltsmBlgs.Enabled = true;

        }

        private void buttonVazgec_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Baslangic);
            EkranDisable();
            EkranTemizle();
            
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Sil);
            groupBoxSrglm.Enabled = true;
           
        }

        private void buttonDüzelt_Click(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Düzelt);
            groupBoxSrglm.Enabled = true;

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri mstr = MusteriNesnesiOlustur();


                if (_aktifIslemMod == IslemMod.Yeni)
                {
                    YeniKaydet(mstr);

                }

                else if (_aktifIslemMod == IslemMod.Düzelt)
                {
                    GüncelleKaydet(mstr);
                }
                if (_aktifIslemMod == IslemMod.Sil)
                {
                    SilKaydet();

                }
                EkranTemizle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        /// <summary>
        /// Database HesapNo ile arama yaparak sorgulama yapar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            //Bilgileri düzeltmek ve silmek için sorgulama yapan komutlar
            try
            {
                groupBoxSrglm.Enabled = true;

                Musteri musSonuc = _buss.MusteriSorgula(ucSayiGirisHesapNo.Deger);

                MusteriBilgileriEkranaSetEt(musSonuc);

                if (_aktifIslemMod == IslemMod.Düzelt)
                {
                    groupBoxGnlMstrBlgs.Enabled = true;
                    groupBoxIltsmBlgs.Enabled = true;
                    groupBoxSbBlgs.Enabled = true;
                    groupBoxSrglm.Enabled = false;
                    buttonSorgula.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Parametre olarak verilen müşteri nesnesini ekrana set eden method
        /// </summary>
        /// <param name="musSonuc"></param>
        private void MusteriBilgileriEkranaSetEt(Musteri musSonuc)
        {
            ucSayiGirisHspNo.Deger = musSonuc.HesapNo;
            ucTextGirisAd.Text = musSonuc.Ad;
            ucTextGirisSyad.Text = musSonuc.Soyad;
            ucSayiGirisTcNo.Deger = musSonuc.TcNo;
            ucSayiGirisYas.Deger = musSonuc.Yas;
            ucComboBoxCinsiyet.XSecilenKey = musSonuc.Cinsiyet;
            ucSayiGirisTlNo.Deger = musSonuc.TelNo;
            sayiVeTextGirisiEmail.Text = musSonuc.Email;
            sayiVeTextGirisiAdres.Text = musSonuc.Adres;
            ucComboBoxSbkd.XSecilenKey = musSonuc.SubeKodu;
            ucComboBoxMstrCsKd.XSecilenKey = musSonuc.MusteriCinsiKodu;
            ucComboBoxCgrfBlgKd.XSecilenKey = musSonuc.CografiBolgeKodu;
            ucComboBoxUyrkKd.XSecilenKey = musSonuc.UyrukKodu;
            dateTimePickerDgmtrh.Value = musSonuc.DogumTarihi.Value;

        }

        private Musteri MusteriNesnesiOlustur()
        {
            Musteri mstr = new Musteri();
            mstr.HesapNo = ucSayiGirisHspNo.Deger;
            mstr.Ad = ucTextGirisAd.Text;
            mstr.Soyad = ucTextGirisSyad.Text;
            mstr.TcNo = ucSayiGirisTcNo.Deger;
            mstr.DogumTarihi = dateTimePickerDgmtrh.Value;
            mstr.Yas = ucSayiGirisYas.Deger;
            mstr.Cinsiyet = ucComboBoxCinsiyet.XSecilenKeyToString;
            mstr.Adres = sayiVeTextGirisiAdres.Text;
            mstr.TelNo = ucSayiGirisTlNo.Deger;
            mstr.Email = sayiVeTextGirisiEmail.Text;
            mstr.MusteriCinsiKodu = ucComboBoxMstrCsKd.XSecilenKeyToString;
            mstr.UyrukKodu = ucComboBoxUyrkKd.XSecilenKeyTolong;
            mstr.CografiBolgeKodu = ucComboBoxCgrfBlgKd.XSecilenKeyTolong;
            mstr.SubeKodu = ucComboBoxSbkd.XSecilenKeyTolong;
            return mstr;
        }

        private void YeniKaydet(Musteri mstr)
        {
            if (mstr.ZorunlulukKontrol())
            {
            bool islemSonuc = _buss.MusteriInsert(mstr);
            if (islemSonuc)
            {
                MessageBox.Show("Kayıt İşlemi Başarılı");
                SetIslemMode(IslemMod.Baslangic);
                EkranDisable();
            }
            else
            {
                MessageBox.Show("Kayıt İşlemi Başarısız ");
            }
        }
        }

        private void SilKaydet()
        {
            bool islemSonuc = _buss.MusteriSil(ucSayiGirisHesapNo.Deger);
            if (islemSonuc)
            {
                MessageBox.Show("Silme İşlemi Başarılı");
                SetIslemMode(IslemMod.Baslangic);
                EkranDisable();
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız ");
            }
        }

        private void GüncelleKaydet(Musteri mstr)
        {
            if(mstr.ZorunlulukKontrol())
            {
            bool islemSonuc = _buss.MusteriGuncelle(mstr);
            if (islemSonuc)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                SetIslemMode(IslemMod.Baslangic);
                EkranDisable();
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız ");
            }
        }
        }

      

     }
 }

