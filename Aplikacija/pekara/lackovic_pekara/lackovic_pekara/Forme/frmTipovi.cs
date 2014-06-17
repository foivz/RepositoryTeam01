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

        /// <summary>
        /// Dohvacaju se svi tipovi proizvoda i ucitavaju u datagrid
        /// </summary>
        private void dohvatiTipoveProizvoda()
        {
            NpgsqlDataReader dr = Upiti.dohvatiTipoveProizvoda();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// Aktivacija btn Dodaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen naziv tipa proizvoda!");
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
        /// <summary>
        /// Aktivacija btnUredi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Aktivacija btnObrisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite izbrisati tip proizvoda?", "Brisanje tipa proizvoda", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    Upiti.brisiTipProizvoda(id);
                    MessageBox.Show("Uspješno obrisan tip proizvoda!");
                    dohvatiTipoveProizvoda();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisan tip proizvoda!");
                }
            }
        }

        string id = "";
        /// <summary>
        /// dataGridView se puni podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[redak].Cells[0].Value.ToString();
                txtNaziv.Text = dataGridView1.Rows[redak].Cells[1].Value.ToString();
                txtOpis.Text = dataGridView1.Rows[redak].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
