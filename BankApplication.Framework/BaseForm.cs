using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApplication.Framework.FrmHelper
{
    public enum IslemMod
    {
        Baslangic,
        Yeni,
        Sil,
        Düzelt,
        Sorgula
    }

    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public IslemMod _aktifIslemMod;

        private void BaseForm_Load(object sender, EventArgs e)
        {
            SetIslemMode(IslemMod.Baslangic);
        }

        /// <summary>
        /// parametre olarak verilen groupboxın içindeki kontrolleri temizler. 
        /// Groupboxın resettext methodu kullanıldıgında groupboxın başlığını sıldığınden dolayı bu şekilde temizleme işlemi yapılıyor
        /// </summary>
        /// <param name="box"></param>
        public void GroupBoxTemizle(GroupBox box)
        {
            foreach (Control ctl in box.Controls)
            {
                if (ctl is GroupBox)
                {
                    GroupBoxTemizle(ctl as GroupBox);
                }
                else if (!(ctl is Label))
                {
                    if (ctl is DataGridView)
                    {
                        (ctl as DataGridView).DataSource = null;
                    }
                    else if(ctl is UcComboBox)
                    {
                        (ctl as UcComboBox).XSecilenKey  = null;
                    }
                    else
                        ctl.ResetText();
                }
            }
        }

        /// <summary>
        /// ekrandaki aktif işlem modu set eder moda göre modbuttonlarının enable-disable ayarlarını set eder.
        /// 
        /// </summary>
        /// <param name="mod"></param>
        public void SetIslemMode(IslemMod mod)
        {
            _aktifIslemMod = mod;
            if (mod == IslemMod.Baslangic)
            {
                buttonYeni.Enabled = true;
                buttonSil.Enabled = true;
                buttonDüzelt.Enabled = true;
                buttonSorgula.Enabled = false;
                buttonVazgec.Enabled = false;
                buttonKaydet.Enabled = false;
                
            }
            else if (mod == IslemMod.Sil)
            {
                buttonYeni.Enabled = false;
                buttonSil.Enabled = false;
                buttonDüzelt.Enabled = false;
                buttonSorgula.Enabled = true;
                buttonVazgec.Enabled = true;
                buttonKaydet.Enabled = true;

            }
            else if (mod == IslemMod.Yeni)
            {
                buttonSil.Enabled = false;
                buttonDüzelt.Enabled = false;
                buttonYeni.Enabled = false;
                buttonVazgec.Enabled = true;
                buttonKaydet.Enabled = true;
            }
            else if (mod == IslemMod.Düzelt)
            {
                buttonSil.Enabled = false;
                buttonYeni.Enabled = false;
                buttonSorgula.Enabled = true;
                buttonDüzelt.Enabled = false;
                buttonVazgec.Enabled = true;
                buttonKaydet.Enabled = true;
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {

        }

           
       
    }
}

