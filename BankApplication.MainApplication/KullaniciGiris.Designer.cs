namespace BankApplication.MainApplication
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxKllancAd = new System.Windows.Forms.TextBox();
            this.textBoxKllncSfr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // buttonEnter
            // 
            this.buttonEnter.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnter.Image")));
            this.buttonEnter.Location = new System.Drawing.Point(241, 24);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(95, 80);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxKllancAd
            // 
            this.textBoxKllancAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKllancAd.Location = new System.Drawing.Point(135, 33);
            this.textBoxKllancAd.Name = "textBoxKllancAd";
            this.textBoxKllancAd.Size = new System.Drawing.Size(100, 21);
            this.textBoxKllancAd.TabIndex = 5;
            // 
            // textBoxKllncSfr
            // 
            this.textBoxKllncSfr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKllncSfr.Location = new System.Drawing.Point(135, 75);
            this.textBoxKllncSfr.Name = "textBoxKllncSfr";
            this.textBoxKllncSfr.PasswordChar = '*';
            this.textBoxKllncSfr.Size = new System.Drawing.Size(100, 21);
            this.textBoxKllncSfr.TabIndex = 6;
            // 
            // KullaniciGiris
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(351, 131);
            this.Controls.Add(this.textBoxKllncSfr);
            this.Controls.Add(this.textBoxKllancAd);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKllancAd;
        private System.Windows.Forms.TextBox textBoxKllncSfr;
        private System.Windows.Forms.Button buttonEnter;
    }
}