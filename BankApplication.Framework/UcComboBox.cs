using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankApplication.FrameWork.CommonHelper;

namespace BankApplication.Framework
{
    public partial class UcComboBox : ComboBox
    {
        private Dictionary<object, object> _itemler = new Dictionary<object, object>();

        public object XSecilenKey
        {
            get
            {
                if (this.SelectedItem != null)
                {
                    if (_itemler.Any(i => i.Value == this.SelectedItem))
                    {
                        return _itemler.ElementAt(this.SelectedIndex).Key;
                    }
                }
                return null;

            }
            set
            {
                if (value != null &&  _itemler.ContainsKey(value))
                {
                    this.SelectedItem = _itemler[value];
                }
                else
                {
                    this.SelectedItem = null;
                }
            }
        }

        public string XSecilenKeyToString
        {
            get { return XSecilenKey == null ? null: XSecilenKey.ToString(); }
        }

        public long? XSecilenKeyTolong
        {
            get { return ConvertHelper.ConvertTo<long?>(XSecilenKey); }
        }

        public UcComboBox()
        {
            InitializeComponent();
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void DegerEkle(object key, object displayValue)
        {
            if(key!=null)
            {
                long sayi = 0;
                bool sayiMi =  long.TryParse(key.ToString(),out sayi);
                if (sayiMi)
                {
                    _itemler.Add(ConvertHelper.ConvertTo<long>( key), displayValue);
                }
                else
                {
                    _itemler.Add(key, displayValue);
                   
                }
                this.Items.Add(displayValue);
            }
            

        }
    }
}
