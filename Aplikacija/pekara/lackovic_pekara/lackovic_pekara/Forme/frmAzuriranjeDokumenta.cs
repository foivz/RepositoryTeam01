using Npgsql;
using PI.Forme;
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
        int idDokumenta=0;
        DataTable dt = new DataTable();
        
        /// <summary>
        /// Kao parametar dobivamo id dokumenta kojeg zelimo azurirati, odnosno
        /// o kojem zelimo prikazati podatke. Ovisno o kojem se id radi, prikazuju 
        /// se u određenim labelama i text boxevima o kojem se dokumentu radi.
        /// 
        /// Zatim se dohvaćaju dokumenti tog tipa, poslovni partneri i repromaterijali
        /// </summary>
        public frmAzuriranjeDokumenta(int id)
        {
            InitializeComponent();
            idDokumenta = id;
            switch (id)
            {
                case 1: lblDokument.Text = "PRIMKA";
                    lblStavka.Text = "REPROMATERIJALI";
                    lblPopust.Visible = false;
                    txtPopust.Text = "0";
                    txtPopust.Visible = false;
                    btnDodaj.Text = "DODAJ PRIMKU";
                    break;
                case 2:
                    lblStavka.Text = "PROIZVODI";
                    lblDokument.Text = "PREDATNICA";
                    lblPopust.Visible = false;
                    txtPopust.Text = "0";
                    txtPopust.Visible = false;
                    btnDodaj.Text = "DODAJ PREDATNICU";
                    break;
                case 3:
                    lblStavka.Text = "REPROMATERIJALI";
                    lblDokument.Text = "IZDATNICA";
                    lblPopust.Visible = false;
                    txtPopust.Text = "0";
                    txtPopust.Visible = false;
                    btnDodaj.Text = "DODAJ IZDATNICU";
                    break;
                case 4:
                    lblStavka.Text = "PROIZVODI";
                    lblDokument.Text = "OTPREMNICA";
                    btnDodaj.Text = "DODAJ OTPREMNICU";
                    break;
            }

            dohvatiDokumente();
            dt.Columns.Add("ID");
            dt.Columns.Add("kolicina");
            dt.Columns.Add("Stanje");
            dt.Columns.Add("popust");
            
            dgrStavke.DataSource = dt;

            if (id != 4)
            {
                dgrStavke.Columns[3].Visible = false;
            }

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
            if (id == 2 || id == 4)
            {
                dohvatiProizvode();
            }
            else
            {
                dohvatiRepromaterijal();
            }
        }
        /// <summary>
        /// dohvaćanje dokumenata iz baze podataka
        /// </summary>
        private void dohvatiDokumente()
        {
            NpgsqlDataReader dr = Upiti.dohvatiDokumente(idDokumenta.ToString());
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dgrPostojeci.DataSource = dt;
        }
        /// <summary>
        /// dohvaćanje repromaterijala iz baze podataka
        /// </summary>
        private void dohvatiRepromaterijal()
        {
            NpgsqlDataReader dr = Upiti.dohvatiRepromaterijal();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dgrRepromaterijali.DataSource = dt;
        }

        /// <summary>
        /// dohvaćanje proizvoda iz baze podataka
        /// </summary>
        private void dohvatiProizvode()
        {
            NpgsqlDataReader dr = Upiti.dohvatiProizvodDokument();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            dr.Dispose();
            dgrRepromaterijali.DataSource = dt;
        }

        /// <summary>
        /// trajno brisanje odabranog dokumenta iz baze podataka
        /// </summary>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int seletirano = dgrPostojeci.CurrentCell.RowIndex;
                Upiti.brisiDokument(dgrPostojeci.Rows[seletirano].Cells[5].Value.ToString(),idDokumenta);
                dohvatiDokumente();
                MessageBox.Show("Uspješno obrisan dokument!");
                if (idDokumenta == 2 || idDokumenta == 4)
                {
                    dohvatiProizvode();
                }
                else
                {
                    dohvatiRepromaterijal();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            int selektirani = dgrPostojeci.CurrentCell.RowIndex;
            int idposlovnogPartnera = int.Parse(dgrPostojeci.Rows[selektirani].Cells[3].Value.ToString());
            int dokument = int.Parse(dgrPostojeci.Rows[selektirani].Cells[5].Value.ToString());
            if (idDokumenta == 1)
            {
                IzvjestajPrimke izvjestajPrimke = new IzvjestajPrimke(idposlovnogPartnera, dokument);
                izvjestajPrimke.ShowDialog();
            }
            else if (idDokumenta == 2)
            {
                IzvjestajPredatnice izvjestajPredatnice = new IzvjestajPredatnice(idposlovnogPartnera, dokument);
                izvjestajPredatnice.ShowDialog();
            }
            else if (idDokumenta == 3)
            {
                IzvjestajIzdatnice izvjestajIzdatnice = new IzvjestajIzdatnice(idposlovnogPartnera, dokument);
                izvjestajIzdatnice.ShowDialog();
            }
            else if (idDokumenta == 4)
            {
                IzvjestajOtpremnice izvjestajOtpremnice = new IzvjestajOtpremnice(idposlovnogPartnera, dokument);
                izvjestajOtpremnice.ShowDialog();
            }

        }

        /// <summary>
        /// dodavanje repromaterijala u dokument
        /// 
        /// Uzmemo repromaterijal iz datagrida (koji sadrzi popis svih repromaterijala)
        /// i dodamo taj repromaterijal u datagrid koji sadrzi repromaterijale za novi dokument.
        /// 
        /// </summary>
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
                        staraKolicina = staraKolicina + novaKolicina;
                        if (idDokumenta == 1 || idDokumenta == 2)
                        {
                            dgrStavke.Rows[indeks].Cells[2].Value = (int.Parse(dgrRepromaterijali.Rows[selektirani].Cells[3].Value.ToString()) + int.Parse(dgrStavke.Rows[indeks].Cells[1].Value.ToString())).ToString();
                        }
                        else
                        {
                            dgrStavke.Rows[indeks].Cells[2].Value = (int.Parse(dgrRepromaterijali.Rows[selektirani].Cells[3].Value.ToString()) - int.Parse(dgrStavke.Rows[indeks].Cells[1].Value.ToString())).ToString();
                        }
                    }
                    else
                    {
                        dr["ID"] = id;
                        dr["kolicina"] = txtKolicina.Text;
                        dr["popust"] = txtPopust.Text;
                        if (idDokumenta == 1 || idDokumenta == 2)
                        {
                            dr["stanje"] = (int.Parse(dgrRepromaterijali.Rows[selektirani].Cells[3].Value.ToString()) + int.Parse(txtKolicina.Text)).ToString();
                        }
                        else
                        {
                            dr["stanje"] = (int.Parse(dgrRepromaterijali.Rows[selektirani].Cells[3].Value.ToString()) - int.Parse(txtKolicina.Text)).ToString();
                        }
                        dt.Rows.Add(dr);
                    }
                    if (int.Parse(dgrStavke.Rows[indeks].Cells[2].Value.ToString()) <= 0)
                    {
                        MessageBox.Show("Stanje na skladištu vam je u minusu!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// <summary>
        /// brisanje repromaterijala iz dokumenta
        /// </summary>
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

        /// <summary>
        /// dodavanje novo kreiranog dokumenta
        /// 
        /// Prvo provjerimo validaciju unesenih podataka,
        /// Zatim pripremimo sve podatke za uspjesno izvrsavanje sql upita
        /// (dodamo sve upisane repromaterijale/proizvode u listu i proslijedimo sve
        /// podatke prema Bazi.
        /// </summary>
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
                for (int i = 0; i < dgrStavke.Rows.Count - 1; i++)
                {
                    switch (idDokumenta)
                    {
                        case 1:
                                Upiti.azurirajRepromaterijalProizvod(dgrStavke.Rows[i].Cells[0].Value.ToString(),
                                    dgrStavke.Rows[i].Cells[1].Value.ToString(), "plus");
                            break;
                        case 2:
                            Upiti.azurirajRepromaterijalProizvod(dgrStavke.Rows[i].Cells[0].Value.ToString(),
                                dgrStavke.Rows[i].Cells[1].Value.ToString(), "plus");
                            break;
                        case 3:
                            Upiti.azurirajRepromaterijalProizvod(dgrStavke.Rows[i].Cells[0].Value.ToString(),
                                dgrStavke.Rows[i].Cells[1].Value.ToString(), "minus");
                            break;
                        case 4:
                            Upiti.azurirajRepromaterijalProizvod(dgrStavke.Rows[i].Cells[0].Value.ToString(),
                                dgrStavke.Rows[i].Cells[1].Value.ToString(), "minus");
                            break;
                    }
                }
                dt.Rows.Clear();
                dohvatiDokumente();
                if (idDokumenta == 2 || idDokumenta == 4)
                {
                    dohvatiProizvode();
                }
                else
                {
                    dohvatiRepromaterijal();
                }
            }
            else
            {

            }
        }

        /// <summary>
        /// brisanje selektiranog proizvoda
        /// </summary>
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

        /// <summary>
        /// zatvaranje forme
        /// </summary>
        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
