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
        
        /// <summary>
        /// pozivanje forme tipovi
        /// </summary>
        private void tipoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipovi tipovi = new frmTipovi();
            tipovi.ShowDialog();
        }

        /// <summary>
        /// pozivanje forme proizvodi
        /// </summary>
        private void proizvodiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProizvodi proizvodi = new frmProizvodi();
            proizvodi.ShowDialog();
        }

        /// <summary>
        /// pozivanje forme sastavnice
        /// </summary>
        private void sastavniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSastavnica sastavnica = new frmSastavnica();
            sastavnica.ShowDialog();
        }

        /// <summary>
        /// pozivanje forme repromaterijal
        /// </summary>
        private void repromaterijalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepromaterijali repromaterijali = new frmRepromaterijali();
            repromaterijali.ShowDialog();
        }

        /// <summary>
        /// pozivanje forme dokumenti
        /// </summary>
        private void dokumentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDokument dokument = new frmDokument();
            dokument.ShowDialog();
        }

        /// <summary>
        /// pozivanje forme poslovni partneri
        /// </summary>
        private void poslovniPartnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoslovniPartner poslovniPartner = new frmPoslovniPartner();
            poslovniPartner.ShowDialog();
        }

        /// <summary>
        /// pozivanje forme osoba
        /// </summary>
        private void osobaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOsoba osoba = new frmOsoba();
            osoba.ShowDialog();
        }
    }
}
