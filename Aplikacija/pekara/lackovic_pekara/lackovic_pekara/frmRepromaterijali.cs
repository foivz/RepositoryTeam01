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
    public partial class frmRepromaterijali : Form
    {
        public frmRepromaterijali()
        {
            InitializeComponent();
            dohvatiRepromaterijal();
            comboBox1.SelectedIndex = 0;
            dohvatiRepromaterijal();
        }

        private void dohvatiRepromaterijal()
        {
            NpgsqlDataReader dr = Upiti.dohvatiRepromaterijal();
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
                string selektiraniTip = cmbTipovi.Text;
                string id = "";
                for (int i = 0; i < selektiraniTip.Length; i++)
                {
                    if (selektiraniTip[i] == '-')
                    {
                        break;
                    }
                    id += selektiraniTip[i].ToString();
                }
                float cijena = 0;
                float.TryParse(txtCijena.Text, out cijena);
                float stanje = 0;
                float.TryParse(txtStanje.Text, out stanje);
                Upiti.unesiProizvod(txtNaziv.Text, cijena, txtOpis.Text, stanje, comboBox1.Text, int.Parse(id));
                MessageBox.Show("Uspješno unešen repromaterijal");
                dohvatiRepromaterijal();
                txtOpis.Text = "";
                txtNaziv.Text = "";
                txtStanje.Text = "0";
                txtCijena.Text = "";
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite izbrisati repromaterijal?", "Brisanje repromaterijala", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    Upiti.brisiRepromaterijal(id);
                    MessageBox.Show("Uspješno obrisan proizvoda!");
                    dohvatiRepromaterijal();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisan repromaterijal!");
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen naziv repromaterijala!");

            }
            else
            {
                string selektiraniTip = cmbTipovi.Text;
                string idTip = "";
                for (int i = 0; i < selektiraniTip.Length; i++)
                {
                    if (selektiraniTip[i] == '-')
                    {
                        break;
                    }
                    idTip += selektiraniTip[i].ToString();
                }
                float cijena = 0;
                float.TryParse(txtCijena.Text, out cijena);
                float stanje = 0;
                float.TryParse(txtStanje.Text, out stanje);
                Upiti.azurirajProizvod(txtNaziv.Text, cijena, txtOpis.Text, stanje, comboBox1.Text, int.Parse(idTip), id);
                MessageBox.Show("Uspješno ažuriran proizvod!");
                dohvatiRepromaterijal();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[redak].Cells[0].Value.ToString();
                txtNaziv.Text = dataGridView1.Rows[redak].Cells[1].Value.ToString();
                txtCijena.Text = dataGridView1.Rows[redak].Cells[2].Value.ToString();
                txtOpis.Text = dataGridView1.Rows[redak].Cells[3].Value.ToString();
                txtStanje.Text = dataGridView1.Rows[redak].Cells[4].Value.ToString();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == dataGridView1.Rows[redak].Cells[5].Value.ToString())
                    {
                        comboBox1.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cmbTipovi.Items.Count; i++)
                {
                    string naziv = "";
                    string trenutniTip = cmbTipovi.Items[i].ToString();
                    int j = 0;
                    for (j = 0; j < trenutniTip.Length; j++)
                    {
                        if (trenutniTip[j] == '-')
                        {
                            break;
                        }
                    }
                    naziv = trenutniTip.Substring(j + 2);
                    if (naziv == dataGridView1.Rows[redak].Cells[6].Value.ToString())
                    {
                        cmbTipovi.SelectedIndex = i;
                    }
                }
            }
            catch
            {

            }
        } 
    }
}
