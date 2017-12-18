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
    public partial class UcTutarGiris : TextBox
    {
        public decimal? Deger
        {
            get
            {
                if (string.IsNullOrEmpty(Text))
                {
                    return null;
                }
                else
                {
                    return Convert.ToDecimal(Text);
                }

            }
            set { Text = value.ToString(); }
        }
        public UcTutarGiris()
        {
            InitializeComponent();
        }

        private void UcTutarGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
