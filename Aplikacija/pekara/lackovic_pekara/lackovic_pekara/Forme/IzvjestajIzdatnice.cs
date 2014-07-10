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
    public partial class IzvjestajIzdatnice : Form
    {
        public IzvjestajIzdatnice( int idposlovnogPartnera, int idDokumenta)
        {
            InitializeComponent();
            this.idDokumenta=idDokumenta;
            this.idPoslovnogPartnera = idposlovnogPartnera;
            this.CenterToParent();
        }

        int idDokumenta;
        int idPoslovnogPartnera;

        private void IzvjestajIzdatnice_Load(object sender, EventArgs e)
        {
            this.repromaterijalproizvodTableAdapter.Fill(this.baza.repromaterijalproizvod, idDokumenta);
            this.poslovnipartnerTableAdapter.Fill(this.baza.poslovnipartner, idPoslovnogPartnera);
            this.reportViewer1.RefreshReport();
        }
    }
}
