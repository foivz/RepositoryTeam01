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
    public partial class frmDokument : Form
    {
        public frmDokument()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        /// <summary>
        /// otvaranje forme za primku
        /// </summary>
        private void btnPrimka_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(1);
            azuriranjeDokumenta.ShowDialog();
        }

        /// <summary>
        /// otvaranje forme za predatnicu
        /// </summary>
        private void btnPredatnica_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(2);
            azuriranjeDokumenta.ShowDialog();
        }

        /// <summary>
        /// otvaranje forme za otpremnicu
        /// </summary>
        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(4);
            azuriranjeDokumenta.ShowDialog();
        }


        private void frmDokument_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// otvaranje forme za izdatnicu
        /// </summary>
        private void btnIzdatnica_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(3);
            azuriranjeDokumenta.ShowDialog();
        }

        /// <summary>
        /// zatvaranje cijele forme
        /// </summary>
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
