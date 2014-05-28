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
    public partial class frmSastavnica : Form
    {
        public frmSastavnica()
        {
            InitializeComponent();
            dohvatiProizvode();
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

        private void dgrProizvodi_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int redak = dgrProizvodi.CurrentCell.RowIndex;
                string id = dgrProizvodi.Rows[redak].Cells[0].Value.ToString();
                NpgsqlDataReader dr = Upiti.dohvatiRepromaterijaleProizvoda(id);
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                dr.Dispose();
                dgrRepromaterijal.DataSource = dt;
                dr = Upiti.dohvatiRepromaterijaleKojeNemaProizvod(id);
                DataTable dt2 = new DataTable();
                dt2.Load(dr);
                dr.Close();
                dr.Dispose();
                dataGridView1.DataSource = dt2;
            }
            catch
            {

            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Jeste li sigurni da želite izbrisati sastavnicu ovog proizvoda?", "Brisanje sastavnice proizvoda", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    string idProizvoda = "" ;
                    string idSastavnice = "";
                    int redak = dgrProizvodi.CurrentCell.RowIndex;
                    idProizvoda = dgrProizvodi.Rows[redak].Cells[0].Value.ToString();

                    redak = dgrRepromaterijal.CurrentCell.RowIndex;
                    idSastavnice = dgrRepromaterijal.Rows[redak].Cells[0].Value.ToString();

                    Upiti.brisiSastavnicuProizvoda(idProizvoda, idSastavnice);
                    MessageBox.Show("Uspješno obrisana sastavnica proizvoda!");
                    dohvatiProizvode();
                }
                catch
                {
                    MessageBox.Show("Nije uspješno obrisana sastavnica proizvoda!");
                }
            }
        }
    }
}
