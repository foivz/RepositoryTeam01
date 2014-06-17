using Npgsql;
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
    public partial class frmOsoba : Form
    {
        public frmOsoba()
        {
            InitializeComponent();
           
        }

        private void dohvatiOsobe()
        {
            NpgsqlDataReader dr = Upiti.dohvatiOsobe();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
        }


        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajOsobu_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" & txtPrezime.Text == "")
            {
                MessageBox.Show("Nije unešeno ime i prezime osobe!");
            }
            else
            {
                Upiti.dodajOsobe(txtIme.Text, txtPrezime.Text, txtUserName.Text, txtLozinka.Text, txtBrojtelefona.Text, txtEmail.Text);
                MessageBox.Show("Uspješno unešena nova osoba!");
                dohvatiOsobe();
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtUserName.Text = "";
                txtLozinka.Text = "";
                txtBrojtelefona.Text = "";
                txtEmail.Text = "";
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite izbrisati osobu?",
              "Brisanje osobe", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    Upiti.brisiOsobe(id);
                    MessageBox.Show("Uspješno obrisana osoba!");
                    dohvatiOsobe();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisana osoba!");
                }
            }
        }

        
        string id = "";
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[redak].Cells[6].Value.ToString();
                txtIme.Text = dataGridView1.Rows[redak].Cells[0].Value.ToString();
                txtPrezime.Text = dataGridView1.Rows[redak].Cells[1].Value.ToString();
                txtUserName.Text = dataGridView1.Rows[redak].Cells[2].Value.ToString();
                txtLozinka.Text = dataGridView1.Rows[redak].Cells[3].Value.ToString();
                txtBrojtelefona.Text = dataGridView1.Rows[redak].Cells[4].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[redak].Cells[5].Value.ToString();
            }
            catch
            {

            }

        }
    }
}
