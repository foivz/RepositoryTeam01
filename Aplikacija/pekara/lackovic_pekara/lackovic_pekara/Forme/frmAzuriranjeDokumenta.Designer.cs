namespace PI
{
    partial class frmAzuriranjeDokumenta
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
            this.dgrPostojeci = new System.Windows.Forms.DataGridView();
            this.dgrRepromaterijali = new System.Windows.Forms.DataGridView();
            this.dgrStavke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPoslovniPartner = new System.Windows.Forms.ComboBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPopust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPopust = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajRepromaterijal = new System.Windows.Forms.Button();
            this.btnBrisiRepromaterijal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblStavka = new System.Windows.Forms.Label();
            this.lblDokument = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPostojeci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRepromaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrPostojeci
            // 
            this.dgrPostojeci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrPostojeci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPostojeci.Location = new System.Drawing.Point(6, 54);
            this.dgrPostojeci.MultiSelect = false;
            this.dgrPostojeci.Name = "dgrPostojeci";
            this.dgrPostojeci.ReadOnly = true;
            this.dgrPostojeci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrPostojeci.Size = new System.Drawing.Size(437, 267);
            this.dgrPostojeci.TabIndex = 0;
            // 
            // dgrRepromaterijali
            // 
            this.dgrRepromaterijali.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrRepromaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrRepromaterijali.Location = new System.Drawing.Point(6, 340);
            this.dgrRepromaterijali.MultiSelect = false;
            this.dgrRepromaterijali.Name = "dgrRepromaterijali";
            this.dgrRepromaterijali.ReadOnly = true;
            this.dgrRepromaterijali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrRepromaterijali.Size = new System.Drawing.Size(437, 231);
            this.dgrRepromaterijali.TabIndex = 2;
            // 
            // dgrStavke
            // 
            this.dgrStavke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgrStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrStavke.Location = new System.Drawing.Point(6, 361);
            this.dgrStavke.MultiSelect = false;
            this.dgrStavke.Name = "dgrStavke";
            this.dgrStavke.ReadOnly = true;
            this.dgrStavke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrStavke.Size = new System.Drawing.Size(471, 215);
            this.dgrStavke.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPoslovniPartner);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblPopust);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPopust);
            this.groupBox1.Controls.Add(this.txtKolicina);
            this.groupBox1.Controls.Add(this.btnDodajRepromaterijal);
            this.groupBox1.Controls.Add(this.btnBrisiRepromaterijal);
            this.groupBox1.Controls.Add(this.dgrStavke);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 582);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje novog dokumenta";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.Red;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(143, 212);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(180, 64);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj primku";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Poslovni partner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dodatni opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datum";
            // 
            // cmbPoslovniPartner
            // 
            this.cmbPoslovniPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoslovniPartner.FormattingEnabled = true;
            this.cmbPoslovniPartner.Location = new System.Drawing.Point(170, 185);
            this.cmbPoslovniPartner.Name = "cmbPoslovniPartner";
            this.cmbPoslovniPartner.Size = new System.Drawing.Size(121, 21);
            this.cmbPoslovniPartner.TabIndex = 12;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(122, 73);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(215, 93);
            this.txtOpis.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Location = new System.Drawing.Point(188, 321);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(40, 13);
            this.lblPopust.TabIndex = 9;
            this.lblPopust.Text = "Popust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Količina";
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(160, 335);
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 7;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(38, 335);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 6;
            // 
            // btnDodajRepromaterijal
            // 
            this.btnDodajRepromaterijal.Location = new System.Drawing.Point(287, 298);
            this.btnDodajRepromaterijal.Name = "btnDodajRepromaterijal";
            this.btnDodajRepromaterijal.Size = new System.Drawing.Size(94, 59);
            this.btnDodajRepromaterijal.TabIndex = 5;
            this.btnDodajRepromaterijal.Text = "Dodaj stavku u dokument";
            this.btnDodajRepromaterijal.UseVisualStyleBackColor = true;
            this.btnDodajRepromaterijal.Click += new System.EventHandler(this.btnDodajRepromaterijal_Click);
            // 
            // btnBrisiRepromaterijal
            // 
            this.btnBrisiRepromaterijal.Location = new System.Drawing.Point(387, 298);
            this.btnBrisiRepromaterijal.Name = "btnBrisiRepromaterijal";
            this.btnBrisiRepromaterijal.Size = new System.Drawing.Size(90, 59);
            this.btnBrisiRepromaterijal.TabIndex = 4;
            this.btnBrisiRepromaterijal.Text = "Briši stavku iz dokumenta";
            this.btnBrisiRepromaterijal.UseVisualStyleBackColor = true;
            this.btnBrisiRepromaterijal.Click += new System.EventHandler(this.btnBrisiRepromaterijal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnZatvori);
            this.groupBox2.Controls.Add(this.lblStavka);
            this.groupBox2.Controls.Add(this.lblDokument);
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Controls.Add(this.btnIspis);
            this.groupBox2.Controls.Add(this.dgrPostojeci);
            this.groupBox2.Controls.Add(this.dgrRepromaterijali);
            this.groupBox2.Location = new System.Drawing.Point(510, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 582);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Postojeći dokumenti i repromaterijali";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.Location = new System.Drawing.Point(270, 21);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(57, 27);
            this.btnZatvori.TabIndex = 21;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblStavka
            // 
            this.lblStavka.AutoSize = true;
            this.lblStavka.Location = new System.Drawing.Point(6, 324);
            this.lblStavka.Name = "lblStavka";
            this.lblStavka.Size = new System.Drawing.Size(76, 13);
            this.lblStavka.TabIndex = 18;
            this.lblStavka.Text = "Repromaterijali";
            // 
            // lblDokument
            // 
            this.lblDokument.AutoSize = true;
            this.lblDokument.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDokument.ForeColor = System.Drawing.Color.Red;
            this.lblDokument.Location = new System.Drawing.Point(6, 26);
            this.lblDokument.Name = "lblDokument";
            this.lblDokument.Size = new System.Drawing.Size(114, 25);
            this.lblDokument.TabIndex = 17;
            this.lblDokument.Text = "Dokumenti";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.Location = new System.Drawing.Point(391, 21);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(52, 27);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIspis.Location = new System.Drawing.Point(333, 21);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(52, 27);
            this.btnIspis.TabIndex = 3;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmAzuriranjeDokumenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(971, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAzuriranjeDokumenta";
            this.Text = "frmAzuriranjeDokumenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgrPostojeci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRepromaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrPostojeci;
        private System.Windows.Forms.DataGridView dgrRepromaterijali;
        private System.Windows.Forms.DataGridView dgrStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajRepromaterijal;
        private System.Windows.Forms.Button btnBrisiRepromaterijal;
        private System.Windows.Forms.TextBox txtPopust;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPoslovniPartner;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label lblStavka;
        private System.Windows.Forms.Label lblDokument;
        private System.Windows.Forms.Button btnZatvori;
    }
}