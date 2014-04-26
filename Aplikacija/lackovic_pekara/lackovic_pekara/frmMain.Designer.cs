namespace lackovic_pekara
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ocisti_timer = new System.Windows.Forms.Timer(this.components);
            this.zaprimanjeMaterijalaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.izdavanjeMaterijalaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeProizvodimaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.zaprimanjeMaterijalaMenu,
            this.izdavanjeMaterijalaMenu,
            this.upravljanjeProizvodimaMenu});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(684, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenu,
            this.logoutMenu,
            this.zatvoriMenu});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // loginMenu
            // 
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.Size = new System.Drawing.Size(152, 22);
            this.loginMenu.Text = "Login";
            this.loginMenu.Click += new System.EventHandler(this.loginMenu_Click);
            // 
            // logoutMenu
            // 
            this.logoutMenu.Name = "logoutMenu";
            this.logoutMenu.Size = new System.Drawing.Size(152, 22);
            this.logoutMenu.Text = "Logout";
            this.logoutMenu.Visible = false;
            this.logoutMenu.Click += new System.EventHandler(this.logoutMenu_Click);
            // 
            // zatvoriMenu
            // 
            this.zatvoriMenu.Name = "zatvoriMenu";
            this.zatvoriMenu.Size = new System.Drawing.Size(152, 22);
            this.zatvoriMenu.Text = "Zatvori";
            this.zatvoriMenu.Click += new System.EventHandler(this.zatvoriMenu_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.status.Location = new System.Drawing.Point(0, 440);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(684, 22);
            this.status.TabIndex = 3;
            this.status.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ocisti_timer
            // 
            this.ocisti_timer.Interval = 8000;
            this.ocisti_timer.Tick += new System.EventHandler(this.ocisti_timer_Tick);
            // 
            // zaprimanjeMaterijalaMenu
            // 
            this.zaprimanjeMaterijalaMenu.Name = "zaprimanjeMaterijalaMenu";
            this.zaprimanjeMaterijalaMenu.Size = new System.Drawing.Size(134, 20);
            this.zaprimanjeMaterijalaMenu.Text = "Zaprimanje materijala";
            this.zaprimanjeMaterijalaMenu.Visible = false;
            // 
            // izdavanjeMaterijalaMenu
            // 
            this.izdavanjeMaterijalaMenu.Name = "izdavanjeMaterijalaMenu";
            this.izdavanjeMaterijalaMenu.Size = new System.Drawing.Size(123, 20);
            this.izdavanjeMaterijalaMenu.Text = "Izdavanje materijala";
            this.izdavanjeMaterijalaMenu.Visible = false;
            // 
            // upravljanjeProizvodimaMenu
            // 
            this.upravljanjeProizvodimaMenu.Name = "upravljanjeProizvodimaMenu";
            this.upravljanjeProizvodimaMenu.Size = new System.Drawing.Size(147, 20);
            this.upravljanjeProizvodimaMenu.Text = "Upravljanje proizvodima";
            this.upravljanjeProizvodimaMenu.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lackovic_pekara.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "Pekara Aplikacija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutMenu;
        private System.Windows.Forms.ToolStripMenuItem zatvoriMenu;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Timer ocisti_timer;
        private System.Windows.Forms.ToolStripMenuItem zaprimanjeMaterijalaMenu;
        private System.Windows.Forms.ToolStripMenuItem izdavanjeMaterijalaMenu;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeProizvodimaMenu;
    }
}

