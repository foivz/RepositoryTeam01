﻿using System;
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
        public IzvjestajOtpremnice(int idDokumenta, int idposlovnogPartnera)
        {
            InitializeComponent();
            this.idDokumenta = idDokumenta;
            this.idPoslovnogPartnera = idposlovnogPartnera;
        }

        int idDokumenta;
        int idPoslovnogPartnera;

        private void IzvjestajOtpremnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza.repromaterijalproizvod' table. You can move, or remove it, as needed.
            this.repromaterijalproizvodTableAdapter.FillBy(this.baza.repromaterijalproizvod,idDokumenta);
            //this.poslovnipartnerTableAdapter.Fill(this.baza.poslovnipartner, idPoslovnogPartnera);
            this.reportViewer1.RefreshReport();
        }
    }
}
