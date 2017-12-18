namespace BankApplication.EkHesap.Forms
{
    partial class EkHesapGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxSorgulama = new System.Windows.Forms.GroupBox();
            this.ucSayiGirisHesapNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEkHspBlglr = new System.Windows.Forms.GroupBox();
            this.ucSayiGirisEkNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.ucTutarGirisBky = new BankApplication.Framework.FrmHelper.UcTutarGiris();
            this.ucComboBoxSbKd = new BankApplication.Framework.UcComboBox();
            this.ucComboBoxDvzKd = new BankApplication.Framework.UcComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewEkHspGrs = new System.Windows.Forms.DataGridView();
            this.groupBoxDtGrdvw = new System.Windows.Forms.GroupBox();
            this.groupBoxModeButonlar.SuspendLayout();
            this.groupBoxSorgulama.SuspendLayout();
            this.groupBoxEkHspBlglr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEkHspGrs)).BeginInit();
            this.groupBoxDtGrdvw.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModeButonlar
            // 
            this.groupBoxModeButonlar.Enabled = true;
            this.groupBoxModeButonlar.Size = new System.Drawing.Size(711, 71);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.Click += new System.EventHandler(this.buttonSorgula_Click);
            // 
            // buttonVazgec
            // 
            this.buttonVazgec.Click += new System.EventHandler(this.buttonVazgec_Click);
            // 
            // buttonDüzelt
            // 
            this.buttonDüzelt.Click += new System.EventHandler(this.buttonDüzelt_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonYeni
            // 
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // groupBoxSorgulama
            // 
            this.groupBoxSorgulama.Controls.Add(this.ucSayiGirisHesapNo);
            this.groupBoxSorgulama.Controls.Add(this.label1);
            this.groupBoxSorgulama.Enabled = false;
            this.groupBoxSorgulama.Location = new System.Drawing.Point(6, 77);
            this.groupBoxSorgulama.Name = "groupBoxSorgulama";
            this.groupBoxSorgulama.Size = new System.Drawing.Size(202, 100);
            this.groupBoxSorgulama.TabIndex = 1;
            this.groupBoxSorgulama.TabStop = false;
            // 
            // ucSayiGirisHesapNo
            // 
            this.ucSayiGirisHesapNo.Deger = null;
            this.ucSayiGirisHesapNo.Location = new System.Drawing.Point(76, 34);
            this.ucSayiGirisHesapNo.Name = "ucSayiGirisHesapNo";
            this.ucSayiGirisHesapNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisHesapNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acount No";
            // 
            // groupBoxEkHspBlglr
            // 
            this.groupBoxEkHspBlglr.Controls.Add(this.ucSayiGirisEkNo);
            this.groupBoxEkHspBlglr.Controls.Add(this.ucTutarGirisBky);
            this.groupBoxEkHspBlglr.Controls.Add(this.ucComboBoxSbKd);
            this.groupBoxEkHspBlglr.Controls.Add(this.ucComboBoxDvzKd);
            this.groupBoxEkHspBlglr.Controls.Add(this.label5);
            this.groupBoxEkHspBlglr.Controls.Add(this.label4);
            this.groupBoxEkHspBlglr.Controls.Add(this.label3);
            this.groupBoxEkHspBlglr.Controls.Add(this.label2);
            this.groupBoxEkHspBlglr.Enabled = false;
            this.groupBoxEkHspBlglr.Location = new System.Drawing.Point(240, 77);
            this.groupBoxEkHspBlglr.Name = "groupBoxEkHspBlglr";
            this.groupBoxEkHspBlglr.Size = new System.Drawing.Size(471, 100);
            this.groupBoxEkHspBlglr.TabIndex = 2;
            this.groupBoxEkHspBlglr.TabStop = false;
            // 
            // ucSayiGirisEkNo
            // 
            this.ucSayiGirisEkNo.Deger = null;
            this.ucSayiGirisEkNo.Location = new System.Drawing.Point(84, 16);
            this.ucSayiGirisEkNo.Name = "ucSayiGirisEkNo";
            this.ucSayiGirisEkNo.ReadOnly = true;
            this.ucSayiGirisEkNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisEkNo.TabIndex = 10;
            // 
            // ucTutarGirisBky
            // 
            this.ucTutarGirisBky.Deger = null;
            this.ucTutarGirisBky.Location = new System.Drawing.Point(84, 55);
            this.ucTutarGirisBky.Name = "ucTutarGirisBky";
            this.ucTutarGirisBky.Size = new System.Drawing.Size(100, 20);
            this.ucTutarGirisBky.TabIndex = 9;
            // 
            // ucComboBoxSbKd
            // 
            this.ucComboBoxSbKd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxSbKd.FormattingEnabled = true;
            this.ucComboBoxSbKd.Location = new System.Drawing.Point(312, 54);
            this.ucComboBoxSbKd.Name = "ucComboBoxSbKd";
            this.ucComboBoxSbKd.Size = new System.Drawing.Size(121, 21);
            this.ucComboBoxSbKd.TabIndex = 8;
            this.ucComboBoxSbKd.XSecilenKey = null;
            // 
            // ucComboBoxDvzKd
            // 
            this.ucComboBoxDvzKd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxDvzKd.FormattingEnabled = true;
            this.ucComboBoxDvzKd.Location = new System.Drawing.Point(313, 16);
            this.ucComboBoxDvzKd.Name = "ucComboBoxDvzKd";
            this.ucComboBoxDvzKd.Size = new System.Drawing.Size(121, 21);
            this.ucComboBoxDvzKd.TabIndex = 7;
            this.ucComboBoxDvzKd.XSecilenKey = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Overdraft No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Branch Code";
            // 
            // dataGridViewEkHspGrs
            // 
            this.dataGridViewEkHspGrs.AllowUserToAddRows = false;
            this.dataGridViewEkHspGrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEkHspGrs.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewEkHspGrs.Name = "dataGridViewEkHspGrs";
            this.dataGridViewEkHspGrs.ReadOnly = true;
            this.dataGridViewEkHspGrs.Size = new System.Drawing.Size(694, 183);
            this.dataGridViewEkHspGrs.TabIndex = 3;
            this.dataGridViewEkHspGrs.DataSourceChanged += new System.EventHandler(this.dataGridViewEkHspGrs_DataSourceChanged);
            this.dataGridViewEkHspGrs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEkHspGrs_RowEnter);
            // 
            // groupBoxDtGrdvw
            // 
            this.groupBoxDtGrdvw.Controls.Add(this.dataGridViewEkHspGrs);
            this.groupBoxDtGrdvw.Location = new System.Drawing.Point(0, 183);
            this.groupBoxDtGrdvw.Name = "groupBoxDtGrdvw";
            this.groupBoxDtGrdvw.Size = new System.Drawing.Size(721, 282);
            this.groupBoxDtGrdvw.TabIndex = 4;
            this.groupBoxDtGrdvw.TabStop = false;
            // 
            // EkHesapGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 396);
            this.Controls.Add(this.groupBoxDtGrdvw);
            this.Controls.Add(this.groupBoxEkHspBlglr);
            this.Controls.Add(this.groupBoxSorgulama);
            this.Name = "EkHesapGiris";
            this.Tag = "";
            this.Text = "Overdraft Input";
            this.Load += new System.EventHandler(this.EkHesapGiris_Load);
            this.Controls.SetChildIndex(this.groupBoxModeButonlar, 0);
            this.Controls.SetChildIndex(this.groupBoxSorgulama, 0);
            this.Controls.SetChildIndex(this.groupBoxEkHspBlglr, 0);
            this.Controls.SetChildIndex(this.groupBoxDtGrdvw, 0);
            this.groupBoxModeButonlar.ResumeLayout(false);
            this.groupBoxSorgulama.ResumeLayout(false);
            this.groupBoxSorgulama.PerformLayout();
            this.groupBoxEkHspBlglr.ResumeLayout(false);
            this.groupBoxEkHspBlglr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEkHspGrs)).EndInit();
            this.groupBoxDtGrdvw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSorgulama;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisHesapNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEkHspBlglr;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisEkNo;
        private Framework.FrmHelper.UcTutarGiris ucTutarGirisBky;
        private Framework.UcComboBox ucComboBoxSbKd;
        private Framework.UcComboBox ucComboBoxDvzKd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewEkHspGrs;
        private System.Windows.Forms.GroupBox groupBoxDtGrdvw;
    }
}