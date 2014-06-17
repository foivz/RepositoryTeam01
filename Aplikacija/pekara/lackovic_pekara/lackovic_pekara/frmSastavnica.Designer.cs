namespace PI
{
    partial class frmSastavnica
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
            this.dgrProizvodi = new System.Windows.Forms.DataGridView();
            this.dgrRepromaterijal = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKolicinaDodaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMjera = new System.Windows.Forms.ComboBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRepromaterijal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrProizvodi
            // 
            this.dgrProizvodi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProizvodi.Location = new System.Drawing.Point(255, 26);
            this.dgrProizvodi.MultiSelect = false;
            this.dgrProizvodi.Name = "dgrProizvodi";
            this.dgrProizvodi.ReadOnly = true;
            this.dgrProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrProizvodi.Size = new System.Drawing.Size(633, 336);
            this.dgrProizvodi.TabIndex = 0;
            this.dgrProizvodi.SelectionChanged += new System.EventHandler(this.dgrProizvodi_SelectionChanged);
            // 
            // dgrRepromaterijal
            // 
            this.dgrRepromaterijal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrRepromaterijal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrRepromaterijal.Location = new System.Drawing.Point(255, 396);
            this.dgrRepromaterijal.MultiSelect = false;
            this.dgrRepromaterijal.Name = "dgrRepromaterijal";
            this.dgrRepromaterijal.ReadOnly = true;
            this.dgrRepromaterijal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrRepromaterijal.Size = new System.Drawing.Size(633, 325);
            this.dgrRepromaterijal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proizvodi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Repromaterijali odabranog proizvoda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repromaterijali koje nema proizvod";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(42, 417);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(67, 31);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnObrisi.Location = new System.Drawing.Point(699, 368);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(189, 22);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obriši repromaterijal iz proizvoda";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 276);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtKolicinaDodaj
            // 
            this.txtKolicinaDodaj.Location = new System.Drawing.Point(12, 342);
            this.txtKolicinaDodaj.Name = "txtKolicinaDodaj";
            this.txtKolicinaDodaj.Size = new System.Drawing.Size(100, 20);
            this.txtKolicinaDodaj.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Količina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mjera";
            // 
            // cmbMjera
            // 
            this.cmbMjera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMjera.FormattingEnabled = true;
            this.cmbMjera.Items.AddRange(new object[] {
            "tona",
            "kg",
            "dag",
            "l"});
            this.cmbMjera.Location = new System.Drawing.Point(128, 342);
            this.cmbMjera.Name = "cmbMjera";
            this.cmbMjera.Size = new System.Drawing.Size(107, 21);
            this.cmbMjera.TabIndex = 13;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(128, 417);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(67, 31);
            this.btnZatvori.TabIndex = 14;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmSastavnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(900, 733);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.cmbMjera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKolicinaDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrRepromaterijal);
            this.Controls.Add(this.dgrProizvodi);
            this.Name = "frmSastavnica";
            this.Text = "frmSastavnica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgrProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRepromaterijal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrProizvodi;
        private System.Windows.Forms.DataGridView dgrRepromaterijal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKolicinaDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMjera;
        private System.Windows.Forms.Button btnZatvori;
    }
}