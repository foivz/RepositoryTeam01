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

        /// <summary>
        /// dohvaćanje repromaterijala i ispis u datagrid
        /// </summary>
        private void dohvatiRepromaterijal()
        {
            NpgsqlDataReader dr = Upiti.dohvatiRepromaterijal();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// aktivacija btn dodaj, prvo se validira upis, ako je upis validan, onda
        /// unesi repromaterijal u bazu
        /// </summary>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen naziv repromaterijala!");
            }
            else
            {
                float stanje = 0;
                float.TryParse(txtStanje.Text, out stanje);
                Upiti.unesiProizvod(txtNaziv.Text, 0, txtOpis.Text, stanje, comboBox1.Text, 0);
                MessageBox.Show("Uspješno unešen repromaterijal");
                dohvatiRepromaterijal();
                txtOpis.Text = "";
                txtNaziv.Text = "";
                txtStanje.Text = "0";
            }
        }

        string id = "";

        /// <summary>
        /// aktivacija btn obriši, brisanje repromaterijala
        /// </summary>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite izbrisati repromaterijal?", "Brisanje repromaterijala", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    Upiti.brisiRepromaterijal(id);
                    MessageBox.Show("Uspješno obrisan repromaterijala!");
                    dohvatiRepromaterijal();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisan repromaterijal!");
                }
            }
        }

        /// <summary>
        /// Aktivacija btnAzuriraj, azuriranje repromaterijala
        /// </summary>
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text == "")
            {
                MessageBox.Show("Nije unešen naziv repromaterijala!");

            }
            else
            {
                float stanje = 0;
                float.TryParse(txtStanje.Text, out stanje);
                Upiti.azurirajRepromaterijal(txtNaziv.Text, 0, txtOpis.Text, stanje, comboBox1.Text, 0, id);
                MessageBox.Show("Uspješno ažuriran repromaterijal!");
                dohvatiRepromaterijal();
            }
        }


        /// <summary>
        /// zatvaranje forme
        /// </summary>
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Kada se promijeni selekcija odabranog retka u datagridu, pune se kontrole tim podacima
        /// </summary>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dataGridView1.CurrentCell.RowIndex;
                id = dataGridView1.Rows[redak].Cells[0].Value.ToString();
                txtNaziv.Text = dataGridView1.Rows[redak].Cells[1].Value.ToString();
                txtOpis.Text = dataGridView1.Rows[redak].Cells[3].Value.ToString();
                txtStanje.Text = dataGridView1.Rows[redak].Cells[4].Value.ToString();
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == dataGridView1.Rows[redak].Cells[5].Value.ToString())
                    {
                        comboBox1.SelectedIndex = i;
                    }
                }
            }
            catch
            {

            }
        } 
    }
}
