namespace PI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sastavniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repromaterijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovniPartnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dokumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacijaToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.osobaToolStripMenuItem,
            this.dokumentiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoviToolStripMenuItem,
            this.proizvodiToolStripMenuItem1,
            this.sastavniceToolStripMenuItem,
            this.repromaterijalToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem.Click += new System.EventHandler(this.proizvodiToolStripMenuItem_Click);
            // 
            // tipoviToolStripMenuItem
            // 
            this.tipoviToolStripMenuItem.Name = "tipoviToolStripMenuItem";
            this.tipoviToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tipoviToolStripMenuItem.Text = "Tipovi";
            this.tipoviToolStripMenuItem.Click += new System.EventHandler(this.tipoviToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem1
            // 
            this.proizvodiToolStripMenuItem1.Name = "proizvodiToolStripMenuItem1";
            this.proizvodiToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.proizvodiToolStripMenuItem1.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem1.Click += new System.EventHandler(this.proizvodiToolStripMenuItem1_Click);
            // 
            // sastavniceToolStripMenuItem
            // 
            this.sastavniceToolStripMenuItem.Name = "sastavniceToolStripMenuItem";
            this.sastavniceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.sastavniceToolStripMenuItem.Text = "Sastavnice";
            this.sastavniceToolStripMenuItem.Click += new System.EventHandler(this.sastavniceToolStripMenuItem_Click);
            // 
            // repromaterijalToolStripMenuItem
            // 
            this.repromaterijalToolStripMenuItem.Name = "repromaterijalToolStripMenuItem";
            this.repromaterijalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.repromaterijalToolStripMenuItem.Text = "Repromaterijal";
            this.repromaterijalToolStripMenuItem.Click += new System.EventHandler(this.repromaterijalToolStripMenuItem_Click);
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poslovniPartnerToolStripMenuItem,
            this.osobaToolStripMenuItem1});
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.osobaToolStripMenuItem.Text = "Ostalo";
            // 
            // poslovniPartnerToolStripMenuItem
            // 
            this.poslovniPartnerToolStripMenuItem.Name = "poslovniPartnerToolStripMenuItem";
            this.poslovniPartnerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.poslovniPartnerToolStripMenuItem.Text = "Poslovni partner";
            this.poslovniPartnerToolStripMenuItem.Click += new System.EventHandler(this.poslovniPartnerToolStripMenuItem_Click);
            // 
            // osobaToolStripMenuItem1
            // 
            this.osobaToolStripMenuItem1.Name = "osobaToolStripMenuItem1";
            this.osobaToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.osobaToolStripMenuItem1.Text = "Osoba";
            // 
            // dokumentiToolStripMenuItem
            // 
            this.dokumentiToolStripMenuItem.Name = "dokumentiToolStripMenuItem";
            this.dokumentiToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.dokumentiToolStripMenuItem.Text = "Dokumenti";
            this.dokumentiToolStripMenuItem.Click += new System.EventHandler(this.dokumentiToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 439);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sastavniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repromaterijalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslovniPartnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dokumentiToolStripMenuItem;
    }
}