namespace BankApplication.MusteriGiris.Forms
{
    partial class FrmMusteriGiris
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
            this.labelHesapNo = new System.Windows.Forms.Label();
            this.ucSayiGirisHesapNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.groupBoxGnlMstrBlgs = new System.Windows.Forms.GroupBox();
            this.ucComboBoxCinsiyet = new BankApplication.Framework.UcComboBox();
            this.ucSayiGirisYas = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.dateTimePickerDgmtrh = new System.Windows.Forms.DateTimePicker();
            this.ucSayiGirisTcNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.ucTextGirisSyad = new BankApplication.Framework.FrmHelper.UcTextGiris();
            this.ucTextGirisAd = new BankApplication.Framework.FrmHelper.UcTextGiris();
            this.ucSayiGirisHspNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.labelCnsyt = new System.Windows.Forms.Label();
            this.labelYas = new System.Windows.Forms.Label();
            this.labelDgmTrh = new System.Windows.Forms.Label();
            this.labelTcNo = new System.Windows.Forms.Label();
            this.labelSyad = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelHspNo = new System.Windows.Forms.Label();
            this.groupBoxSbBlgs = new System.Windows.Forms.GroupBox();
            this.ucComboBoxCgrfBlgKd = new BankApplication.Framework.UcComboBox();
            this.ucComboBoxUyrkKd = new BankApplication.Framework.UcComboBox();
            this.ucComboBoxMstrCsKd = new BankApplication.Framework.UcComboBox();
            this.ucComboBoxSbkd = new BankApplication.Framework.UcComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUK = new System.Windows.Forms.Label();
            this.labelCBK = new System.Windows.Forms.Label();
            this.labelMCK = new System.Windows.Forms.Label();
            this.groupBoxIltsmBlgs = new System.Windows.Forms.GroupBox();
            this.sayiVeTextGirisiEmail = new BankApplication.Framework.SayiVeTextGirisi();
            this.sayiVeTextGirisiAdres = new BankApplication.Framework.SayiVeTextGirisi();
            this.ucSayiGirisTlNo = new BankApplication.Framework.FrmHelper.UcSayiGiris();
            this.labelAdrs = new System.Windows.Forms.Label();
            this.labelEml = new System.Windows.Forms.Label();
            this.labelTlNo = new System.Windows.Forms.Label();
            this.groupBoxSrglm = new System.Windows.Forms.GroupBox();
            this.groupBoxModeButonlar.SuspendLayout();
            this.groupBoxGnlMstrBlgs.SuspendLayout();
            this.groupBoxSbBlgs.SuspendLayout();
            this.groupBoxIltsmBlgs.SuspendLayout();
            this.groupBoxSrglm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModeButonlar
            // 
            this.groupBoxModeButonlar.Enabled = true;
            this.groupBoxModeButonlar.Size = new System.Drawing.Size(723, 76);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.TabIndex = 4;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.TabIndex = 5;
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
            // labelHesapNo
            // 
            this.labelHesapNo.AutoSize = true;
            this.labelHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelHesapNo.Location = new System.Drawing.Point(3, 27);
            this.labelHesapNo.Name = "labelHesapNo";
            this.labelHesapNo.Size = new System.Drawing.Size(64, 13);
            this.labelHesapNo.TabIndex = 1;
            this.labelHesapNo.Text = "Account No";
            // 
            // ucSayiGirisHesapNo
            // 
            this.ucSayiGirisHesapNo.Deger = null;
            this.ucSayiGirisHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucSayiGirisHesapNo.Location = new System.Drawing.Point(73, 24);
            this.ucSayiGirisHesapNo.Name = "ucSayiGirisHesapNo";
            this.ucSayiGirisHesapNo.Size = new System.Drawing.Size(113, 20);
            this.ucSayiGirisHesapNo.TabIndex = 0;
            // 
            // groupBoxGnlMstrBlgs
            // 
            this.groupBoxGnlMstrBlgs.Controls.Add(this.ucComboBoxCinsiyet);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.ucSayiGirisYas);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.dateTimePickerDgmtrh);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.ucSayiGirisTcNo);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.ucTextGirisSyad);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.ucTextGirisAd);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.ucSayiGirisHspNo);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelCnsyt);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelYas);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelDgmTrh);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelTcNo);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelSyad);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelAd);
            this.groupBoxGnlMstrBlgs.Controls.Add(this.labelHspNo);
            this.groupBoxGnlMstrBlgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxGnlMstrBlgs.Location = new System.Drawing.Point(0, 82);
            this.groupBoxGnlMstrBlgs.Name = "groupBoxGnlMstrBlgs";
            this.groupBoxGnlMstrBlgs.Size = new System.Drawing.Size(503, 148);
            this.groupBoxGnlMstrBlgs.TabIndex = 1;
            this.groupBoxGnlMstrBlgs.TabStop = false;
            this.groupBoxGnlMstrBlgs.Text = "General Customer Information";
            // 
            // ucComboBoxCinsiyet
            // 
            this.ucComboBoxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucComboBoxCinsiyet.FormattingEnabled = true;
            this.ucComboBoxCinsiyet.Location = new System.Drawing.Point(324, 76);
            this.ucComboBoxCinsiyet.Name = "ucComboBoxCinsiyet";
            this.ucComboBoxCinsiyet.Size = new System.Drawing.Size(116, 21);
            this.ucComboBoxCinsiyet.TabIndex = 7;
            this.ucComboBoxCinsiyet.XSecilenKey = null;
            // 
            // ucSayiGirisYas
            // 
            this.ucSayiGirisYas.Deger = null;
            this.ucSayiGirisYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucSayiGirisYas.Location = new System.Drawing.Point(324, 48);
            this.ucSayiGirisYas.Name = "ucSayiGirisYas";
            this.ucSayiGirisYas.Size = new System.Drawing.Size(116, 20);
            this.ucSayiGirisYas.TabIndex = 5;
            // 
            // dateTimePickerDgmtrh
            // 
            this.dateTimePickerDgmtrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerDgmtrh.Location = new System.Drawing.Point(324, 17);
            this.dateTimePickerDgmtrh.Name = "dateTimePickerDgmtrh";
            this.dateTimePickerDgmtrh.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerDgmtrh.TabIndex = 4;
            // 
            // ucSayiGirisTcNo
            // 
            this.ucSayiGirisTcNo.Deger = null;
            this.ucSayiGirisTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucSayiGirisTcNo.Location = new System.Drawing.Point(93, 110);
            this.ucSayiGirisTcNo.MaxLength = 11;
            this.ucSayiGirisTcNo.Name = "ucSayiGirisTcNo";
            this.ucSayiGirisTcNo.Size = new System.Drawing.Size(100, 20);
            this.ucSayiGirisTcNo.TabIndex = 3;
            // 
            // ucTextGirisSyad
            // 
            this.ucTextGirisSyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucTextGirisSyad.Location = new System.Drawing.Point(93, 79);
            this.ucTextGirisSyad.Name = "ucTextGirisSyad";
            this.ucTextGirisSyad.Size = new System.Drawing.Size(100, 20);
            this.ucTextGirisSyad.TabIndex = 2;
            // 
            // ucTextGirisAd
            // 
            this.ucTextGirisAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucTextGirisAd.Location = new System.Drawing.Point(93, 48);
            this.ucTextGirisAd.Name = "ucTextGirisAd";
            this.ucTextGirisAd.Size = new System.Drawing.Size(100, 20);
            this.ucTextGirisAd.TabIndex = 1;
            // 
            // ucSayiGirisHspNo
            // 
            this.ucSayiGirisHspNo.Deger = null;
            this.ucSayiGirisHspNo.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucSayiGirisHspNo.Location = new System.Drawing.Point(93, 17);
            this.ucSayiGirisHspNo.Name = "ucSayiGirisHspNo";
            this.ucSayiGirisHspNo.ReadOnly = true;
            this.ucSayiGirisHspNo.Size = new System.Drawing.Size(100, 22);
            this.ucSayiGirisHspNo.TabIndex = 0;
            // 
            // labelCnsyt
            // 
            this.labelCnsyt.AutoSize = true;
            this.labelCnsyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCnsyt.Location = new System.Drawing.Point(276, 79);
            this.labelCnsyt.Name = "labelCnsyt";
            this.labelCnsyt.Size = new System.Drawing.Size(25, 13);
            this.labelCnsyt.TabIndex = 6;
            this.labelCnsyt.Text = "Sex";
            // 
            // labelYas
            // 
            this.labelYas.AutoSize = true;
            this.labelYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelYas.Location = new System.Drawing.Point(275, 48);
            this.labelYas.Name = "labelYas";
            this.labelYas.Size = new System.Drawing.Size(26, 13);
            this.labelYas.TabIndex = 5;
            this.labelYas.Text = "Age";
            // 
            // labelDgmTrh
            // 
            this.labelDgmTrh.AutoSize = true;
            this.labelDgmTrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDgmTrh.Location = new System.Drawing.Point(235, 21);
            this.labelDgmTrh.Name = "labelDgmTrh";
            this.labelDgmTrh.Size = new System.Drawing.Size(66, 13);
            this.labelDgmTrh.TabIndex = 4;
            this.labelDgmTrh.Text = "Date of Birth";
            // 
            // labelTcNo
            // 
            this.labelTcNo.AutoSize = true;
            this.labelTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTcNo.Location = new System.Drawing.Point(65, 110);
            this.labelTcNo.Name = "labelTcNo";
            this.labelTcNo.Size = new System.Drawing.Size(18, 13);
            this.labelTcNo.TabIndex = 3;
            this.labelTcNo.Text = "ID";
            // 
            // labelSyad
            // 
            this.labelSyad.AutoSize = true;
            this.labelSyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSyad.Location = new System.Drawing.Point(34, 82);
            this.labelSyad.Name = "labelSyad";
            this.labelSyad.Size = new System.Drawing.Size(49, 13);
            this.labelSyad.TabIndex = 2;
            this.labelSyad.Text = "Surname";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelAd.Location = new System.Drawing.Point(48, 51);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(35, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Name";
            // 
            // labelHspNo
            // 
            this.labelHspNo.AutoSize = true;
            this.labelHspNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelHspNo.Location = new System.Drawing.Point(19, 20);
            this.labelHspNo.Name = "labelHspNo";
            this.labelHspNo.Size = new System.Drawing.Size(64, 13);
            this.labelHspNo.TabIndex = 0;
            this.labelHspNo.Text = "Account No";
            // 
            // groupBoxSbBlgs
            // 
            this.groupBoxSbBlgs.Controls.Add(this.ucComboBoxCgrfBlgKd);
            this.groupBoxSbBlgs.Controls.Add(this.ucComboBoxUyrkKd);
            this.groupBoxSbBlgs.Controls.Add(this.ucComboBoxMstrCsKd);
            this.groupBoxSbBlgs.Controls.Add(this.ucComboBoxSbkd);
            this.groupBoxSbBlgs.Controls.Add(this.label1);
            this.groupBoxSbBlgs.Controls.Add(this.labelUK);
            this.groupBoxSbBlgs.Controls.Add(this.labelCBK);
            this.groupBoxSbBlgs.Controls.Add(this.labelMCK);
            this.groupBoxSbBlgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxSbBlgs.Location = new System.Drawing.Point(330, 236);
            this.groupBoxSbBlgs.Name = "groupBoxSbBlgs";
            this.groupBoxSbBlgs.Size = new System.Drawing.Size(396, 153);
            this.groupBoxSbBlgs.TabIndex = 3;
            this.groupBoxSbBlgs.TabStop = false;
            this.groupBoxSbBlgs.Text = "Branch Information";
            // 
            // ucComboBoxCgrfBlgKd
            // 
            this.ucComboBoxCgrfBlgKd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxCgrfBlgKd.FormattingEnabled = true;
            this.ucComboBoxCgrfBlgKd.Location = new System.Drawing.Point(162, 103);
            this.ucComboBoxCgrfBlgKd.Name = "ucComboBoxCgrfBlgKd";
            this.ucComboBoxCgrfBlgKd.Size = new System.Drawing.Size(121, 21);
            this.ucComboBoxCgrfBlgKd.TabIndex = 30;
            this.ucComboBoxCgrfBlgKd.XSecilenKey = null;
            // 
            // ucComboBoxUyrkKd
            // 
            this.ucComboBoxUyrkKd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxUyrkKd.FormattingEnabled = true;
            this.ucComboBoxUyrkKd.Location = new System.Drawing.Point(162, 75);
            this.ucComboBoxUyrkKd.Name = "ucComboBoxUyrkKd";
            this.ucComboBoxUyrkKd.Size = new System.Drawing.Size(121, 21);
            this.ucComboBoxUyrkKd.TabIndex = 29;
            this.ucComboBoxUyrkKd.XSecilenKey = null;
            // 
            // ucComboBoxMstrCsKd
            // 
            this.ucComboBoxMstrCsKd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxMstrCsKd.FormattingEnabled = true;
            this.ucComboBoxMstrCsKd.Location = new System.Drawing.Point(162, 44);
            this.ucComboBoxMstrCsKd.Name = "ucComboBoxMstrCsKd";
            this.ucComboBoxMstrCsKd.Size = new System.Drawing.Size(121, 21);
            this.ucComboBoxMstrCsKd.TabIndex = 28;
            this.ucComboBoxMstrCsKd.XSecilenKey = null;
            // 
            // ucComboBoxSbkd
            // 
            this.ucComboBoxSbkd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ucComboBoxSbkd.FormattingEnabled = true;
            this.ucComboBoxSbkd.Location = new System.Drawing.Point(162, 17);
            this.ucComboBoxSbkd.Name = "ucComboBoxSbkd";
            this.ucComboBoxSbkd.Size = new System.Drawing.Size(121, 21);
            this.ucComboBoxSbkd.TabIndex = 27;
            this.ucComboBoxSbkd.XSecilenKey = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(77, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Branch Code";
            // 
            // labelUK
            // 
            this.labelUK.AutoSize = true;
            this.labelUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelUK.Location = new System.Drawing.Point(62, 80);
            this.labelUK.Name = "labelUK";
            this.labelUK.Size = new System.Drawing.Size(84, 13);
            this.labelUK.TabIndex = 22;
            this.labelUK.Text = "Nationality Code";
            // 
            // labelCBK
            // 
            this.labelCBK.AutoSize = true;
            this.labelCBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCBK.Location = new System.Drawing.Point(30, 110);
            this.labelCBK.Name = "labelCBK";
            this.labelCBK.Size = new System.Drawing.Size(116, 13);
            this.labelCBK.TabIndex = 21;
            this.labelCBK.Text = "Geographic Region No";
            // 
            // labelMCK
            // 
            this.labelMCK.AutoSize = true;
            this.labelMCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelMCK.Location = new System.Drawing.Point(40, 50);
            this.labelMCK.Name = "labelMCK";
            this.labelMCK.Size = new System.Drawing.Size(106, 13);
            this.labelMCK.TabIndex = 20;
            this.labelMCK.Text = "Customer Type Code";
            // 
            // groupBoxIltsmBlgs
            // 
            this.groupBoxIltsmBlgs.Controls.Add(this.sayiVeTextGirisiEmail);
            this.groupBoxIltsmBlgs.Controls.Add(this.sayiVeTextGirisiAdres);
            this.groupBoxIltsmBlgs.Controls.Add(this.ucSayiGirisTlNo);
            this.groupBoxIltsmBlgs.Controls.Add(this.labelAdrs);
            this.groupBoxIltsmBlgs.Controls.Add(this.labelEml);
            this.groupBoxIltsmBlgs.Controls.Add(this.labelTlNo);
            this.groupBoxIltsmBlgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxIltsmBlgs.Location = new System.Drawing.Point(0, 236);
            this.groupBoxIltsmBlgs.Name = "groupBoxIltsmBlgs";
            this.groupBoxIltsmBlgs.Size = new System.Drawing.Size(324, 153);
            this.groupBoxIltsmBlgs.TabIndex = 2;
            this.groupBoxIltsmBlgs.TabStop = false;
            this.groupBoxIltsmBlgs.Text = "Contact Information";
            // 
            // sayiVeTextGirisiEmail
            // 
            this.sayiVeTextGirisiEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sayiVeTextGirisiEmail.Location = new System.Drawing.Point(75, 47);
            this.sayiVeTextGirisiEmail.Name = "sayiVeTextGirisiEmail";
            this.sayiVeTextGirisiEmail.Size = new System.Drawing.Size(137, 20);
            this.sayiVeTextGirisiEmail.TabIndex = 1;
            // 
            // sayiVeTextGirisiAdres
            // 
            this.sayiVeTextGirisiAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sayiVeTextGirisiAdres.Location = new System.Drawing.Point(75, 75);
            this.sayiVeTextGirisiAdres.Multiline = true;
            this.sayiVeTextGirisiAdres.Name = "sayiVeTextGirisiAdres";
            this.sayiVeTextGirisiAdres.Size = new System.Drawing.Size(243, 72);
            this.sayiVeTextGirisiAdres.TabIndex = 2;
            // 
            // ucSayiGirisTlNo
            // 
            this.ucSayiGirisTlNo.Deger = null;
            this.ucSayiGirisTlNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ucSayiGirisTlNo.Location = new System.Drawing.Point(75, 20);
            this.ucSayiGirisTlNo.Name = "ucSayiGirisTlNo";
            this.ucSayiGirisTlNo.Size = new System.Drawing.Size(135, 20);
            this.ucSayiGirisTlNo.TabIndex = 0;
            // 
            // labelAdrs
            // 
            this.labelAdrs.AutoSize = true;
            this.labelAdrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelAdrs.Location = new System.Drawing.Point(28, 81);
            this.labelAdrs.Name = "labelAdrs";
            this.labelAdrs.Size = new System.Drawing.Size(39, 13);
            this.labelAdrs.TabIndex = 2;
            this.labelAdrs.Text = "Adress";
            // 
            // labelEml
            // 
            this.labelEml.AutoSize = true;
            this.labelEml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelEml.Location = new System.Drawing.Point(30, 54);
            this.labelEml.Name = "labelEml";
            this.labelEml.Size = new System.Drawing.Size(32, 13);
            this.labelEml.TabIndex = 1;
            this.labelEml.Text = "Email";
            // 
            // labelTlNo
            // 
            this.labelTlNo.AutoSize = true;
            this.labelTlNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTlNo.Location = new System.Drawing.Point(26, 20);
            this.labelTlNo.Name = "labelTlNo";
            this.labelTlNo.Size = new System.Drawing.Size(39, 13);
            this.labelTlNo.TabIndex = 0;
            this.labelTlNo.Text = "Tel No";
            // 
            // groupBoxSrglm
            // 
            this.groupBoxSrglm.Controls.Add(this.labelHesapNo);
            this.groupBoxSrglm.Controls.Add(this.ucSayiGirisHesapNo);
            this.groupBoxSrglm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxSrglm.Location = new System.Drawing.Point(509, 82);
            this.groupBoxSrglm.Name = "groupBoxSrglm";
            this.groupBoxSrglm.Size = new System.Drawing.Size(217, 148);
            this.groupBoxSrglm.TabIndex = 4;
            this.groupBoxSrglm.TabStop = false;
            this.groupBoxSrglm.Text = "Inquiry";
            // 
            // FrmMusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 384);
            this.Controls.Add(this.groupBoxSrglm);
            this.Controls.Add(this.groupBoxIltsmBlgs);
            this.Controls.Add(this.groupBoxSbBlgs);
            this.Controls.Add(this.groupBoxGnlMstrBlgs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmMusteriGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Definition";
            this.Load += new System.EventHandler(this.MusteriGiris_Load);
            this.Controls.SetChildIndex(this.groupBoxModeButonlar, 0);
            this.Controls.SetChildIndex(this.groupBoxGnlMstrBlgs, 0);
            this.Controls.SetChildIndex(this.groupBoxSbBlgs, 0);
            this.Controls.SetChildIndex(this.groupBoxIltsmBlgs, 0);
            this.Controls.SetChildIndex(this.groupBoxSrglm, 0);
            this.groupBoxModeButonlar.ResumeLayout(false);
            this.groupBoxGnlMstrBlgs.ResumeLayout(false);
            this.groupBoxGnlMstrBlgs.PerformLayout();
            this.groupBoxSbBlgs.ResumeLayout(false);
            this.groupBoxSbBlgs.PerformLayout();
            this.groupBoxIltsmBlgs.ResumeLayout(false);
            this.groupBoxIltsmBlgs.PerformLayout();
            this.groupBoxSrglm.ResumeLayout(false);
            this.groupBoxSrglm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHesapNo;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisHesapNo;
        private System.Windows.Forms.GroupBox groupBoxGnlMstrBlgs;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisYas;
        private System.Windows.Forms.DateTimePicker dateTimePickerDgmtrh;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisTcNo;
        private Framework.FrmHelper.UcTextGiris ucTextGirisSyad;
        private Framework.FrmHelper.UcTextGiris ucTextGirisAd;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisHspNo;
        private System.Windows.Forms.Label labelCnsyt;
        private System.Windows.Forms.Label labelYas;
        private System.Windows.Forms.Label labelDgmTrh;
        private System.Windows.Forms.Label labelTcNo;
        private System.Windows.Forms.Label labelSyad;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelHspNo;
        private System.Windows.Forms.GroupBox groupBoxSbBlgs;
        private System.Windows.Forms.Label labelUK;
        private System.Windows.Forms.Label labelMCK;
        private System.Windows.Forms.GroupBox groupBoxIltsmBlgs;
        private Framework.FrmHelper.UcSayiGiris ucSayiGirisTlNo;
        private System.Windows.Forms.Label labelAdrs;
        private System.Windows.Forms.Label labelEml;
        private System.Windows.Forms.Label labelTlNo;
        private System.Windows.Forms.Label labelCBK;
        private System.Windows.Forms.Label label1;
        private Framework.SayiVeTextGirisi sayiVeTextGirisiAdres;
        private Framework.SayiVeTextGirisi sayiVeTextGirisiEmail;
        private System.Windows.Forms.GroupBox groupBoxSrglm;
        private Framework.UcComboBox ucComboBoxCinsiyet;
        private Framework.UcComboBox ucComboBoxCgrfBlgKd;
        private Framework.UcComboBox ucComboBoxUyrkKd;
        private Framework.UcComboBox ucComboBoxMstrCsKd;
        private Framework.UcComboBox ucComboBoxSbkd;

    }
}