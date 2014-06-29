using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.Forme
{
    public partial class IzvjestajPrimke : Form
    {
        public IzvjestajPrimke(int idDokumenta, int idposlovnogPartnera)
        {
            InitializeComponent();
            this.idDokumenta = idDokumenta;
            this.idPoslovnogPartnera = idposlovnogPartnera;
        }

        int idDokumenta;
        int idPoslovnogPartnera;

        private void IzvjestajPrimke_Load(object sender, EventArgs e)
        {
            this.poslovnipartnerTableAdapter.Fill(this.baza.poslovnipartner, idPoslovnogPartnera);
            this.reportViewer1.RefreshReport();
        }
    }
}
