using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PI
{
    public partial class frmPoslovniPartner : Form
    {
        public frmPoslovniPartner()
        {
            InitializeComponent();
            dohvatiPoslovnePartnere();
        }

        private void dohvatiPoslovnePartnere()
        {
            NpgsqlDataReader dr = Upiti.dohvatiPoslovnePartnere();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
        }
 
        string id = "";
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[redak].Cells[4].Value.ToString();
                txtNaziv.Text = dataGridView1.Rows[redak].Cells[0].Value.ToString();
                txtAdresa.Text = dataGridView1.Rows[redak].Cells[1].Value.ToString();
                txtKontakt.Text = dataGridView1.Rows[redak].Cells[2].Value.ToString();
                txtDodatno.Text = dataGridView1.Rows[redak].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen poslovni partner!");
            }
            else
            {
                Upiti.dodajOsobe(txtNaziv.Text, txtAdresa.Text, txtKontakt.Text, txtDodatno.Text);
                MessageBox.Show("Uspješno unesen poslovni partner");
                dohvatiPoslovnePartnere();
                txtNaziv.Text = "";
                txtAdresa.Text = "";
                txtKontakt.Text = "";
                txtDodatno.Text = "";
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite izbrisati poslovnog partnera?",
                "Brisanje poslovnog partnera", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    Upiti.brisiPoslovnePartnere(id);
                    MessageBox.Show("Uspješno obrisan poslovni partner!");
                    dohvatiPoslovnePartnere();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisan poslovni partner!");
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Upiti.azurirajPoslovnePartnere(txtNaziv.Text, txtAdresa.Text, txtKontakt.Text, txtDodatno.Text, id);
            dohvatiPoslovnePartnere();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
