namespace PI
{
    partial class frmDokument
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
            this.btnPrimka = new System.Windows.Forms.Button();
            this.btnPredatnica = new System.Windows.Forms.Button();
            this.btnIzdatnica = new System.Windows.Forms.Button();
            this.btnOtpremnica = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrimka
            // 
            this.btnPrimka.Location = new System.Drawing.Point(241, 121);
            this.btnPrimka.Name = "btnPrimka";
            this.btnPrimka.Size = new System.Drawing.Size(75, 23);
            this.btnPrimka.TabIndex = 0;
            this.btnPrimka.Text = "Primka";
            this.btnPrimka.UseVisualStyleBackColor = true;
            this.btnPrimka.Click += new System.EventHandler(this.btnPrimka_Click);
            // 
            // btnPredatnica
            // 
            this.btnPredatnica.Location = new System.Drawing.Point(241, 150);
            this.btnPredatnica.Name = "btnPredatnica";
            this.btnPredatnica.Size = new System.Drawing.Size(75, 23);
            this.btnPredatnica.TabIndex = 1;
            this.btnPredatnica.Text = "Predatnica";
            this.btnPredatnica.UseVisualStyleBackColor = true;
            this.btnPredatnica.Click += new System.EventHandler(this.btnPredatnica_Click);
            // 
            // btnIzdatnica
            // 
            this.btnIzdatnica.Location = new System.Drawing.Point(241, 179);
            this.btnIzdatnica.Name = "btnIzdatnica";
            this.btnIzdatnica.Size = new System.Drawing.Size(75, 23);
            this.btnIzdatnica.TabIndex = 2;
            this.btnIzdatnica.Text = "Izdatnica";
            this.btnIzdatnica.UseVisualStyleBackColor = true;
            this.btnIzdatnica.Click += new System.EventHandler(this.btnIzdatnica_Click);
            // 
            // btnOtpremnica
            // 
            this.btnOtpremnica.Location = new System.Drawing.Point(241, 208);
            this.btnOtpremnica.Name = "btnOtpremnica";
            this.btnOtpremnica.Size = new System.Drawing.Size(75, 23);
            this.btnOtpremnica.TabIndex = 3;
            this.btnOtpremnica.Text = "Otpremnica";
            this.btnOtpremnica.UseVisualStyleBackColor = true;
            this.btnOtpremnica.Click += new System.EventHandler(this.btnOtpremnica_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(241, 237);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmDokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnOtpremnica);
            this.Controls.Add(this.btnIzdatnica);
            this.Controls.Add(this.btnPredatnica);
            this.Controls.Add(this.btnPrimka);
            this.Name = "frmDokument";
            this.Text = "frmDokument";
            this.Load += new System.EventHandler(this.frmDokument_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrimka;
        private System.Windows.Forms.Button btnPredatnica;
        private System.Windows.Forms.Button btnIzdatnica;
        private System.Windows.Forms.Button btnOtpremnica;
        private System.Windows.Forms.Button btnZatvori;
    }
}