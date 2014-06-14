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
    public partial class IzvjestajOtpremnice : Form
    {
        public IzvjestajOtpremnice()
        {
            InitializeComponent();
        }

        private void IzvjestajOtpremnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pekara_bazaDataSet.dokument' table. You can move, or remove it, as needed.
            this.dokumentTableAdapter.Fill(this.pekara_bazaDataSet.dokument,i);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
