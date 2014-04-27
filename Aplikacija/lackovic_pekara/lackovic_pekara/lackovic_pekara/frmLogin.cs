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
    public partial class frmLogin : Form
    {
        private frmMain parent;
        public frmLogin(frmMain arg)
        {
            InitializeComponent();
            parent = arg;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string lozinka = txtPassword.Text;
            this.osobaTableAdapter.FillByUsername(pekara_bazaDataSet.osoba, username);
            try
            {
                string ime = this.pekara_bazaDataSet.osoba.Rows[0]["ime"].ToString();
                string ocekivana_lozinka = this.pekara_bazaDataSet.osoba.Rows[0]["lozinka"].ToString();
                if (ocekivana_lozinka == lozinka)
                {
                    parent.after_login(ime);
                    this.Close();
                }
                else {
                    txtPassword.Text = "";
                    lblgreska.Visible = true;
                    lblgreska.Text = "Pogrešna lozinka";
                }
            }
            catch {
                txtUsername.Text = "";
                txtPassword.Text = "";
                lblgreska.Visible = true;
                lblgreska.Text = "Nepostojeći korisnik";
                return;
            }
           
        }
    }
}
