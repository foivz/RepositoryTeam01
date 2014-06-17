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
    public partial class frmAzuriranjeDokumenta : Form
    {
        int idDokumenta;
        DataTable dt = new DataTable();

        public frmAzuriranjeDokumenta(int id)
        {
            InitializeComponent();
            idDokumenta = id;
            dohvatiDokumente();
            dohvatiRepromaterijal();
            dt.Columns.Add("ID");
            dt.Columns.Add("kolicina");
            dt.Columns.Add("popust");
            dgrStavke.DataSource = dt;
            NpgsqlDataReader dr = Upiti.dohvatiPoslovnePartnere();
            while (dr.Read())
            {
                cmbPoslovniPartner.Items.Add(dr[4].ToString()+"-"+dr[0].ToString());
            }
            dr.Close();
            dr.Dispose();
            try
            {
                cmbPoslovniPartner.SelectedIndex = 0;
            }
            catch
            {
            }
            dohvatiProizvode();
        }

        private void dohvatiDokumente()
        {
            NpgsqlDataReader dr = Upiti.dohvatiDokumente(idDokumenta.ToString());
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dgrPostojeci.DataSource = dt;
        }

        private void dohvatiRepromaterijal()
        {
            NpgsqlDataReader dr = Upiti.dohvatiRepromaterijal();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dgrRepromaterijali.DataSource = dt;
        }

        private void dohvatiProizvode()
        {
            NpgsqlDataReader dr = Upiti.dohvatiProizvod();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dgrProizvodi.DataSource = dt;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            
        }


        private void btnDodajRepromaterijal_Click(object sender, EventArgs e)
        {
            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli kolicinu!");
            }
            else if (txtPopust.Text == "")
            {
                MessageBox.Show("Niste unijeli popust!");
            }
            else
            {
                DataRow dr = dt.NewRow();
                try
                {
                    int selektirani = dgrRepromaterijali.CurrentCell.RowIndex;
                    string id = dgrRepromaterijali.Rows[selektirani].Cells[0].Value.ToString();

                    bool duplikat = false;
                    int indeks = 0;
                    for (int i = 0; i < dgrStavke.Rows.Count-1; i++)
                    {
                        if (dgrStavke.Rows[i].Cells[0].Value.ToString() == id)
                        {
                            duplikat = true;
                            indeks = i;
                        }
                    }
                    if (duplikat)
                    {
                        string staraKolicina = dgrStavke.Rows[indeks].Cells[1].Value.ToString();
                        int novaKolicina = int.Parse(txtKolicina.Text) + int.Parse(staraKolicina);
                        dgrStavke.Rows[indeks].Cells[1].Value = novaKolicina.ToString();
                    }
                    else
                    {
                        dr["ID"] = id;
                        dr["kolicina"] = txtKolicina.Text;
                        dr["popust"] = txtPopust.Text;
                        dt.Rows.Add(dr);
                    }
                }
                catch
                {

                }
            }
        }

        private void btnBrisiRepromaterijal_Click(object sender, EventArgs e)
        {
            try
            {
                int selektirani = dgrStavke.CurrentCell.RowIndex;
                dgrStavke.Rows.RemoveAt(selektirani);
            }
            catch
            {

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite upisati ovaj dokument, time se mijenja stanje robe na skladištu",
                "Jeste li sigurni", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                string odabraniPartner=cmbPoslovniPartner.Text;
                string idPartnera="";
                for(int i=0;i<odabraniPartner.Length;i++){
                    if(odabraniPartner[i]=='-'){
                        break;
                    }
                   idPartnera+=odabraniPartner[i].ToString();
                }
                List<string> kolicine = new List<string>();
                List<string> popusti = new List<string>();
                List<string> repromaterijali = new List<string>();

                for (int i = 0; i < dgrStavke.Rows.Count - 1; i++)
                {
                    kolicine.Add(dgrStavke.Rows[i].Cells[1].Value.ToString());
                    popusti.Add(dgrStavke.Rows[i].Cells[2].Value.ToString());
                    repromaterijali.Add(dgrStavke.Rows[i].Cells[0].Value.ToString());
                }

                Upiti.dodajDokument(dateTimePicker1.Value.ToShortDateString(),txtOpis.Text,idDokumenta.ToString(),idPartnera,kolicine,popusti,repromaterijali);   
            }
            else
            {

            }
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            if (txtKolicina.Text == "")
            {
                MessageBox.Show("Niste unijeli kolicinu!");
            }
            else if (txtPopust.Text == "")
            {
                MessageBox.Show("Niste unijeli popust!");
            }
            else
            {
                DataRow dr = dt.NewRow();
                try
                {
                    int selektirani = dgrProizvodi.CurrentCell.RowIndex;
                    string id = dgrProizvodi.Rows[selektirani].Cells[0].Value.ToString();

                    bool duplikat = false;
                    int indeks = 0;
                    for (int i = 0; i < dgrStavke.Rows.Count - 1; i++)
                    {
                        if (dgrStavke.Rows[i].Cells[0].Value.ToString() == id)
                        {
                            duplikat = true;
                            indeks = i;
                        }
                    }
                    if (duplikat)
                    {
                        string staraKolicina = dgrStavke.Rows[indeks].Cells[1].Value.ToString();
                        int novaKolicina = int.Parse(txtKolicina.Text) + int.Parse(staraKolicina);
                        dgrStavke.Rows[indeks].Cells[1].Value = novaKolicina.ToString();
                    }
                    else
                    {
                        dr["ID"] = id;
                        dr["kolicina"] = txtKolicina.Text;
                        dr["popust"] = txtPopust.Text;
                        dt.Rows.Add(dr);
                    }
                }
                catch
                {

                }
            }
        }

        private void btnBrisiProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                int selektirani = dgrStavke.CurrentCell.RowIndex;
                dgrStavke.Rows.RemoveAt(selektirani);
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
