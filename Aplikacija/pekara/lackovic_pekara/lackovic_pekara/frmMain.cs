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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipovi tipovi = new frmTipovi();
            tipovi.ShowDialog();
        }

        private void proizvodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProizvodi proizvodi = new frmProizvodi();
            proizvodi.ShowDialog();
        }

        private void sastavniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSastavnica sastavnica = new frmSastavnica();
            sastavnica.ShowDialog();
        }
    }
}
