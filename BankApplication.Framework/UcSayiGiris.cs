using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApplication.Framework.FrmHelper
{
    public partial class UcSayiGiris : TextBox
    {
       
        public UcSayiGiris()
        {
            InitializeComponent();
        }

        /// <summary>
        /// text alanına girilen veriyi sayı formatında get set yapar.
        /// </summary>
       public long? Deger
        {
            get 
            {
                if (string.IsNullOrEmpty(Text))
                {
                    return null;
                }
                else
                {
                    return Convert.ToInt64(Text); 
                }                
                
            }
            set { Text = value.ToString(); }
        }
        
        private void UcSayiGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keychar 8 backspace belirtir.
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;
                
            }
        }
    }
}
