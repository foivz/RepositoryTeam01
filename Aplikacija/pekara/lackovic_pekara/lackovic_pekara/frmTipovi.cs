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
    public partial class frmTipovi : Form
    {
        public frmTipovi()
        {
            InitializeComponent();
            dohvatiTipoveProizvoda();
        }
        private void dohvatiTipoveProizvoda()
        {
            NpgsqlDataReader dr = Upiti.dohvatiTipoveProizvoda();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen naziv proizvoda!");
            }
            else
            {
                Upiti.unesiTipProizvoda(txtNaziv.Text, txtOpis.Text);
                MessageBox.Show("Uspješno unesen tip proizvoda");
                dohvatiTipoveProizvoda();
                txtOpis.Text = "";
                txtNaziv.Text = "";
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen naziv proizvoda!");

            }
            else
            {
                Upiti.azurirajTipProizvoda(id, txtNaziv.Text, txtOpis.Text);
                MessageBox.Show("Uspješno ažuriran tip proizvoda!");
                dohvatiTipoveProizvoda();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                Upiti.brisiProizvod(id);
                MessageBox.Show("Uspješno obrisan tip proizvoda!");
                dohvatiTipoveProizvoda();
            }
            catch
            {
                MessageBox.Show("Nije uspješno obrisan tip proizvoda!");
            }
        }

        string id = "";

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[redak].Cells[0].Value.ToString();
                txtNaziv.Text= dataGridView1.Rows[redak].Cells[1].Value.ToString();
                txtOpis.Text = dataGridView1.Rows[redak].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
