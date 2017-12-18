namespace BankApplication.ParaAktarma.Forms
{
    partial class ParaAktarma
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
            this.groupBoxPrAktrnHsp = new System.Windows.Forms.GroupBox();
            this.ucSayiGirisGönderenEkNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.ucSayiGirisGönderenHesapNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ucSayiGirisAlanHesapNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.ucSayiGirisAlanEkNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.groupBoxParaAktarlnHsp = new System.Windows.Forms.GroupBox();
            this.groupBoxTtrGrs = new System.Windows.Forms.GroupBox();
            this.ucTutarGirisTutar = new BankApplication.Framework.FrmHelper.UcTutarGiris();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewParaGndrnnBlglr = new System.Windows.Forms.DataGridView();
            this.dataGridViewPralnnBlglr = new System.Windows.Forms.DataGridView();
            this.groupBoxDtgrdPrAktrm = new System.Windows.Forms.GroupBox();
            this.groupBoxModeButonlar.SuspendLayout();
            this.groupBoxPrAktrnHsp.SuspendLayout();
            this.groupBoxParaAktarlnHsp.SuspendLayout();
            this.groupBoxTtrGrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParaGndrnnBlglr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPralnnBlglr)).BeginInit();
            this.groupBoxDtgrdPrAktrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModeButonlar
            // 
            this.groupBoxModeButonlar.Enabled = true;
            this.groupBoxModeButonlar.Size = new System.Drawing.Size(716, 71);
            this.groupBoxModeButonlar.TabIndex = 3;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.TabIndex = 1;
            this.buttonSorgula.Click += new System.EventHandler(this.buttonSorgula_Click);
            // 
            // buttonVazgec
            // 
            this.buttonVazgec.TabIndex = 2;
            this.buttonVazgec.Click += new System.EventHandler(this.buttonVazgec_Click);
            // 
            // buttonDüzelt
            // 
            this.buttonDüzelt.TabIndex = 5;
            this.buttonDüzelt.Visible = false;
            // 
            // buttonSil
            // 
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Visible = false;
            // 
            // buttonYeni
            // 
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // groupBoxPrAktrnHsp
            // 
            this.groupBoxPrAktrnHsp.Controls.Add(this.ucSayiGirisGönderenEkNo);
            this.groupBoxPrAktrnHsp.Controls.Add(this.ucSayiGirisGönderenHesapNo);
            this.groupBoxPrAktrnHsp.Controls.Add(this.label2);
            this.groupBoxPrAktrnHsp.Controls.Add(this.label1);
            this.groupBoxPrAktrnHsp.Enabled = false;
            this.groupBoxPrAktrnHsp.Location = new System.Drawing.Point(12, 77);
            this.groupBoxPrAktrnHsp.Name = "groupBoxPrAktrnHsp";
            this.groupBoxPrAktrnHsp.Size = new System.Drawing.Size(243, 100);
            this.groupBoxPrAktrnHsp.TabIndex = 0;
            this.groupBoxPrAktrnHsp.TabStop = false;
            this.groupBoxPrAktrnHsp.Text = "Money Sender Account";
            // 
            // ucSayiGirisGönderenEkNo
            // 
            this.ucSayiGirisGönderenEkNo.Deger = null;
            this.ucSayiGirisGönderenEkNo.Location = new System.Drawing.Point(79, 72);
            this.ucSayiGirisGönderenEkNo.Name = "ucSayiGirisGönderenEkNo";
            this.ucSayiGirisGönderenEkNo.ReadOnly = true;
            this.ucSayiGirisGönderenEkNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisGönderenEkNo.TabIndex = 0;
            // 
            // ucSayiGirisGönderenHesapNo
            // 
            this.ucSayiGirisGönderenHesapNo.Deger = null;
            this.ucSayiGirisGönderenHesapNo.Location = new System.Drawing.Point(79, 26);
            this.ucSayiGirisGönderenHesapNo.Name = "ucSayiGirisGönderenHesapNo";
            this.ucSayiGirisGönderenHesapNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisGönderenHesapNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Overdraft No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Account No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acount No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Overdraft No";
            // 
            // ucSayiGirisAlanHesapNo
            // 
            this.ucSayiGirisAlanHesapNo.Deger = null;
            this.ucSayiGirisAlanHesapNo.Location = new System.Drawing.Point(86, 26);
            this.ucSayiGirisAlanHesapNo.Name = "ucSayiGirisAlanHesapNo";
            this.ucSayiGirisAlanHesapNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisAlanHesapNo.TabIndex = 0;
            // 
            // ucSayiGirisAlanEkNo
            // 
            this.ucSayiGirisAlanEkNo.Deger = null;
            this.ucSayiGirisAlanEkNo.Location = new System.Drawing.Point(86, 66);
            this.ucSayiGirisAlanEkNo.Name = "ucSayiGirisAlanEkNo";
            this.ucSayiGirisAlanEkNo.ReadOnly = true;
            this.ucSayiGirisAlanEkNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisAlanEkNo.TabIndex = 1;
            // 
            // groupBoxParaAktarlnHsp
            // 
            this.groupBoxParaAktarlnHsp.Controls.Add(this.ucSayiGirisAlanHesapNo);
            this.groupBoxParaAktarlnHsp.Controls.Add(this.label4);
            this.groupBoxParaAktarlnHsp.Controls.Add(this.ucSayiGirisAlanEkNo);
            this.groupBoxParaAktarlnHsp.Controls.Add(this.label3);
            this.groupBoxParaAktarlnHsp.Enabled = false;
            this.groupBoxParaAktarlnHsp.Location = new System.Drawing.Point(463, 77);
            this.groupBoxParaAktarlnHsp.Name = "groupBoxParaAktarlnHsp";
            this.groupBoxParaAktarlnHsp.Size = new System.Drawing.Size(245, 100);
            this.groupBoxParaAktarlnHsp.TabIndex = 1;
            this.groupBoxParaAktarlnHsp.TabStop = false;
            this.groupBoxParaAktarlnHsp.Text = "Money Received Account";
            // 
            // groupBoxTtrGrs
            // 
            this.groupBoxTtrGrs.Controls.Add(this.ucTutarGirisTutar);
            this.groupBoxTtrGrs.Controls.Add(this.label5);
            this.groupBoxTtrGrs.Enabled = false;
            this.groupBoxTtrGrs.Location = new System.Drawing.Point(261, 77);
            this.groupBoxTtrGrs.Name = "groupBoxTtrGrs";
            this.groupBoxTtrGrs.Size = new System.Drawing.Size(196, 100);
            this.groupBoxTtrGrs.TabIndex = 2;
            this.groupBoxTtrGrs.TabStop = false;
            this.groupBoxTtrGrs.Text = "Amount Input";
            // 
            // ucTutarGirisTutar
            // 
            this.ucTutarGirisTutar.Deger = null;
            this.ucTutarGirisTutar.Location = new System.Drawing.Point(57, 30);
            this.ucTutarGirisTutar.Name = "ucTutarGirisTutar";
            this.ucTutarGirisTutar.Size = new System.Drawing.Size(100, 20);
            this.ucTutarGirisTutar.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount";
            // 
            // dataGridViewParaGndrnnBlglr
            // 
            this.dataGridViewParaGndrnnBlglr.AllowUserToAddRows = false;
            this.dataGridViewParaGndrnnBlglr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParaGndrnnBlglr.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewParaGndrnnBlglr.Name = "dataGridViewParaGndrnnBlglr";
            this.dataGridViewParaGndrnnBlglr.ReadOnly = true;
            this.dataGridViewParaGndrnnBlglr.Size = new System.Drawing.Size(335, 173);
            this.dataGridViewParaGndrnnBlglr.TabIndex = 4;
            this.dataGridViewParaGndrnnBlglr.DataSourceChanged += new System.EventHandler(this.dataGridViewParaGndrnnBlglr_DataSourceChanged);
            this.dataGridViewParaGndrnnBlglr.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParaGndrnnBlglr_RowEnter);
            // 
            // dataGridViewPralnnBlglr
            // 
            this.dataGridViewPralnnBlglr.AllowUserToAddRows = false;
            this.dataGridViewPralnnBlglr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPralnnBlglr.Location = new System.Drawing.Point(357, 19);
            this.dataGridViewPralnnBlglr.Name = "dataGridViewPralnnBlglr";
            this.dataGridViewPralnnBlglr.ReadOnly = true;
            this.dataGridViewPralnnBlglr.Size = new System.Drawing.Size(335, 173);
            this.dataGridViewPralnnBlglr.TabIndex = 5;
            this.dataGridViewPralnnBlglr.DataSourceChanged += new System.EventHandler(this.dataGridViewPralnnBlglr_DataSourceChanged);
            this.dataGridViewPralnnBlglr.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPralnnBlglr_RowEnter);
            // 
            // groupBoxDtgrdPrAktrm
            // 
            this.groupBoxDtgrdPrAktrm.Controls.Add(this.dataGridViewParaGndrnnBlglr);
            this.groupBoxDtgrdPrAktrm.Controls.Add(this.dataGridViewPralnnBlglr);
            this.groupBoxDtgrdPrAktrm.Location = new System.Drawing.Point(10, 183);
            this.groupBoxDtgrdPrAktrm.Name = "groupBoxDtgrdPrAktrm";
            this.groupBoxDtgrdPrAktrm.Size = new System.Drawing.Size(698, 211);
            this.groupBoxDtgrdPrAktrm.TabIndex = 6;
            this.groupBoxDtgrdPrAktrm.TabStop = false;
            // 
            // ParaAktarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 383);
            this.Controls.Add(this.groupBoxDtgrdPrAktrm);
            this.Controls.Add(this.groupBoxTtrGrs);
            this.Controls.Add(this.groupBoxParaAktarlnHsp);
            this.Controls.Add(this.groupBoxPrAktrnHsp);
            this.Name = "ParaAktarma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Transfer";
            this.Load += new System.EventHandler(this.ParaAktarma_Load);
            this.Controls.SetChildIndex(this.groupBoxModeButonlar, 0);
            this.Controls.SetChildIndex(this.groupBoxPrAktrnHsp, 0);
            this.Controls.SetChildIndex(this.groupBoxParaAktarlnHsp, 0);
            this.Controls.SetChildIndex(this.groupBoxTtrGrs, 0);
            this.Controls.SetChildIndex(this.groupBoxDtgrdPrAktrm, 0);
            this.groupBoxModeButonlar.ResumeLayout(false);
            this.groupBoxPrAktrnHsp.ResumeLayout(false);
            this.groupBoxPrAktrnHsp.PerformLayout();
            this.groupBoxParaAktarlnHsp.ResumeLayout(false);
            this.groupBoxParaAktarlnHsp.PerformLayout();
            this.groupBoxTtrGrs.ResumeLayout(false);
            this.groupBoxTtrGrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParaGndrnnBlglr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPralnnBlglr)).EndInit();
            this.groupBoxDtgrdPrAktrm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrAktrnHsp;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisGönderenEkNo;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisGönderenHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisAlanHesapNo;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisAlanEkNo;
        private System.Windows.Forms.GroupBox groupBoxParaAktarlnHsp;
        private System.Windows.Forms.GroupBox groupBoxTtrGrs;
        private Framework.FrmHelper.UcTutarGiris ucTutarGirisTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewParaGndrnnBlglr;
        private System.Windows.Forms.DataGridView dataGridViewPralnnBlglr;
        private System.Windows.Forms.GroupBox groupBoxDtgrdPrAktrm;
    }
}