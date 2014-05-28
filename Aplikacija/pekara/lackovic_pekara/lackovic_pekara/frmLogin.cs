using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string lozinka = txtPassword.Text;
            if (Upiti.provjeriLogin(username, lozinka))
            {
                frmMain glavna = new frmMain();
                glavna.ShowDialog();
                lblgreska.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else
            {
                lblgreska.Text = "Nije uspješan login u sustav!";
                lblgreska.Visible = true;
            }
        }
    }
}
