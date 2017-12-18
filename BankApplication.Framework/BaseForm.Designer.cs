namespace BankApplication.Framework.FrmHelper
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.groupBoxModeButonlar = new System.Windows.Forms.GroupBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonSorgula = new System.Windows.Forms.Button();
            this.buttonVazgec = new System.Windows.Forms.Button();
            this.buttonDüzelt = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.groupBoxModeButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModeButonlar
            // 
            this.groupBoxModeButonlar.Controls.Add(this.buttonKaydet);
            this.groupBoxModeButonlar.Controls.Add(this.buttonSorgula);
            this.groupBoxModeButonlar.Controls.Add(this.buttonVazgec);
            this.groupBoxModeButonlar.Controls.Add(this.buttonDüzelt);
            this.groupBoxModeButonlar.Controls.Add(this.buttonSil);
            this.groupBoxModeButonlar.Controls.Add(this.buttonYeni);
            this.groupBoxModeButonlar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxModeButonlar.Enabled = false;
            this.groupBoxModeButonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBoxModeButonlar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxModeButonlar.Name = "groupBoxModeButonlar";
            this.groupBoxModeButonlar.Size = new System.Drawing.Size(712, 81);
            this.groupBoxModeButonlar.TabIndex = 0;
            this.groupBoxModeButonlar.TabStop = false;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(618, 19);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(82, 46);
            this.buttonKaydet.TabIndex = 5;
            this.buttonKaydet.Text = "Save";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSorgula.Image = ((System.Drawing.Image)(resources.GetObject("buttonSorgula.Image")));
            this.buttonSorgula.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSorgula.Location = new System.Drawing.Point(406, 19);
            this.buttonSorgula.Name = "buttonSorgula";
            this.buttonSorgula.Size = new System.Drawing.Size(82, 46);
            this.buttonSorgula.TabIndex = 4;
            this.buttonSorgula.Text = "Search";
            this.buttonSorgula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSorgula.UseVisualStyleBackColor = true;
            // 
            // buttonVazgec
            // 
            this.buttonVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonVazgec.Image = ((System.Drawing.Image)(resources.GetObject("buttonVazgec.Image")));
            this.buttonVazgec.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonVazgec.Location = new System.Drawing.Point(512, 19);
            this.buttonVazgec.Name = "buttonVazgec";
            this.buttonVazgec.Size = new System.Drawing.Size(82, 46);
            this.buttonVazgec.TabIndex = 3;
            this.buttonVazgec.Text = "Cancel";
            this.buttonVazgec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVazgec.UseVisualStyleBackColor = true;
            // 
            // buttonDüzelt
            // 
            this.buttonDüzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDüzelt.Image = ((System.Drawing.Image)(resources.GetObject("buttonDüzelt.Image")));
            this.buttonDüzelt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonDüzelt.Location = new System.Drawing.Point(224, 19);
            this.buttonDüzelt.Name = "buttonDüzelt";
            this.buttonDüzelt.Size = new System.Drawing.Size(82, 46);
            this.buttonDüzelt.TabIndex = 2;
            this.buttonDüzelt.Text = "Update";
            this.buttonDüzelt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDüzelt.UseVisualStyleBackColor = true;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonSil.Location = new System.Drawing.Point(113, 19);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(95, 46);
            this.buttonSil.TabIndex = 1;
            this.buttonSil.Text = "Delete";
            this.buttonSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // buttonYeni
            // 
            this.buttonYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeni.Image = ((System.Drawing.Image)(resources.GetObject("buttonYeni.Image")));
            this.buttonYeni.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonYeni.Location = new System.Drawing.Point(12, 19);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(82, 46);
            this.buttonYeni.TabIndex = 0;
            this.buttonYeni.Text = "New";
            this.buttonYeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYeni.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 387);
            this.Controls.Add(this.groupBoxModeButonlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.groupBoxModeButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBoxModeButonlar;
        protected System.Windows.Forms.Button buttonKaydet;
        protected System.Windows.Forms.Button buttonSorgula;
        protected System.Windows.Forms.Button buttonVazgec;
        protected System.Windows.Forms.Button buttonDüzelt;
        protected System.Windows.Forms.Button buttonSil;
        protected System.Windows.Forms.Button buttonYeni;

    }
}