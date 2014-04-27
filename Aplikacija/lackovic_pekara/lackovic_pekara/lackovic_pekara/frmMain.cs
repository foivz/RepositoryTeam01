using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lackovic_pekara
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string user = "";

        public void after_login(string korisnik) {
            user = korisnik;
            logoutMenu.Visible = true;
            loginMenu.Visible = false;
            zaprimanjeMaterijalaMenu.Visible = true;
            izdavanjeMaterijalaMenu.Visible = true;
            upravljanjeProizvodimaMenu.Visible = true;
            statusLabel.Text = "Logiran korisnik: " + korisnik;
            ocisti_timer.Enabled = true;
        }

        private void login() {
            bool IsOpen = false;
            foreach (Form aktivne_forme in Application.OpenForms)
            {
                if (aktivne_forme.Text == "Login")
                {
                    IsOpen = true;
                    aktivne_forme.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmLogin instanca = new frmLogin(this);
                instanca.MdiParent = this;
                instanca.Show();
            }
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            logoutMenu.Visible = false;
            loginMenu.Visible = true;
            zaprimanjeMaterijalaMenu.Visible = false;
            izdavanjeMaterijalaMenu.Visible = false;
            upravljanjeProizvodimaMenu.Visible = false;
            statusLabel.Text = "Odjava korisnika: " + user;
            user = "";
            ocisti_timer.Enabled = true;
        }

        private void zatvoriMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult potvrda = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?", "Izlaz?", MessageBoxButtons.YesNo);
            if (potvrda == DialogResult.Yes)
            {
                // nop
            }
            if (potvrda == DialogResult.No)
            {
                e.Cancel = true;
            }   
        }

        private void loginMenu_Click(object sender, EventArgs e)
        {
            login();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            login();
        }

        private void ocisti_timer_Tick(object sender, EventArgs e)
        {
            statusLabel.Text = "";
            ocisti_timer.Enabled = false;
        }

       
    }
}
