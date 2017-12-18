namespace BankApplication.MainApplication
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.buttonPrAktrm = new System.Windows.Forms.Button();
            this.buttonEkHesapGiris = new System.Windows.Forms.Button();
            this.buttonMusteriGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPrAktrm
            // 
            this.buttonPrAktrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrAktrm.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrAktrm.Image")));
            this.buttonPrAktrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrAktrm.Location = new System.Drawing.Point(124, 104);
            this.buttonPrAktrm.Name = "buttonPrAktrm";
            this.buttonPrAktrm.Size = new System.Drawing.Size(173, 55);
            this.buttonPrAktrm.TabIndex = 2;
            this.buttonPrAktrm.Text = "Money Transfer";
            this.buttonPrAktrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPrAktrm.UseVisualStyleBackColor = true;
            this.buttonPrAktrm.Click += new System.EventHandler(this.buttonPrAktrm_Click);
            // 
            // buttonEkHesapGiris
            // 
            this.buttonEkHesapGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkHesapGiris.Image = ((System.Drawing.Image)(resources.GetObject("buttonEkHesapGiris.Image")));
            this.buttonEkHesapGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEkHesapGiris.Location = new System.Drawing.Point(236, 21);
            this.buttonEkHesapGiris.Name = "buttonEkHesapGiris";
            this.buttonEkHesapGiris.Size = new System.Drawing.Size(185, 56);
            this.buttonEkHesapGiris.TabIndex = 1;
            this.buttonEkHesapGiris.Text = "Account Transaction";
            this.buttonEkHesapGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEkHesapGiris.UseVisualStyleBackColor = true;
            this.buttonEkHesapGiris.Click += new System.EventHandler(this.buttonEkHesapGiris_Click);
            // 
            // buttonMusteriGiris
            // 
            this.buttonMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMusteriGiris.Image = ((System.Drawing.Image)(resources.GetObject("buttonMusteriGiris.Image")));
            this.buttonMusteriGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusteriGiris.Location = new System.Drawing.Point(12, 21);
            this.buttonMusteriGiris.Name = "buttonMusteriGiris";
            this.buttonMusteriGiris.Size = new System.Drawing.Size(185, 56);
            this.buttonMusteriGiris.TabIndex = 0;
            this.buttonMusteriGiris.Text = "Customer Transactions";
            this.buttonMusteriGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMusteriGiris.UseVisualStyleBackColor = true;
            this.buttonMusteriGiris.Click += new System.EventHandler(this.buttonMusteriGiris_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 191);
            this.Controls.Add(this.buttonPrAktrm);
            this.Controls.Add(this.buttonEkHesapGiris);
            this.Controls.Add(this.buttonMusteriGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMusteriGiris;
        private System.Windows.Forms.Button buttonEkHesapGiris;
        private System.Windows.Forms.Button buttonPrAktrm;
    }
}

