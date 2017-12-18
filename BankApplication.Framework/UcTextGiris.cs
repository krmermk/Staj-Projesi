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
    /// <summary>
    /// ilk oluşturuldıgında textboxdan bir farkı olmamasına ragmen kendi kontrolumuzde olan 
    /// ve ilerde yapılacak değişikliklerde tek noktadan kontrol sağlaması amacıyla oluşturulmuştur.
    /// </summary>
    public partial class UcTextGiris : TextBox
    {
        public UcTextGiris()
        {
            InitializeComponent();
        }

        private void UcTextGiris_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
