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

        private void btnPrimka_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(1);
            azuriranjeDokumenta.ShowDialog();
        }

        private void btnPredatnica_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(2);
            azuriranjeDokumenta.ShowDialog();
        }

        private void btnOtpremnica_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(4);
            azuriranjeDokumenta.ShowDialog();
        }

        private void btnZatvori(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDokument_Load(object sender, EventArgs e)
        {

        }

        private void btnIzdatnica_Click(object sender, EventArgs e)
        {
            frmAzuriranjeDokumenta azuriranjeDokumenta = new frmAzuriranjeDokumenta(3);
            azuriranjeDokumenta.ShowDialog();
        }
    }
}
