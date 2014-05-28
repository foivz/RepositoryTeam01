using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PI
{
    class Upiti
    {
        public static bool provjeriLogin(string username, string password)
        {
            NpgsqlDataReader dr;
            string sql = string.Format("SELECT*FROM osoba WHERE username='{0}' AND lozinka='{1}'", username, password);
            dr = Baza.Instance.dohvati_podatke(sql);
            bool uspjesno = false;
            while (dr.Read())
            {
                uspjesno = true;
            }
            dr.Close();
            dr.Dispose();
            return uspjesno;
        }

        public static NpgsqlDataReader dohvatiTipoveProizvoda()
        {
            string sql = "SELECT*FROM tipproizvoda";
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void unesiTipProizvoda(string naziv, string opis)
        {
            string sql = string.Format("INSERT INTO tipproizvoda(naziv,opis) VALUES('{0}','{1}')", naziv, opis);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static void azurirajTipProizvoda(string id, string naziv, string opis)
        {
            string sql = string.Format("UPDATE tipproizvoda SET naziv='{0}', opis='{1}' WHERE \"ID\"='{2}'", naziv, opis, id);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static void brisiTipProizvoda(string id)
        {
            string sql=string.Format("DELETE FROM tipproizvoda WHERE \"ID\"='{0}'",id);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static NpgsqlDataReader dohvatiProizvod()
        {
            string sql = "SELECT \"repromaterijalproizvod\".\"ID\", \"repromaterijalproizvod\".naziv, cijena, \"repromaterijalproizvod\".opis, stanje, mjera,"
                          +"\"tipproizvoda\".naziv AS tip FROM tipproizvoda,repromaterijalproizvod WHERE tipproizvoda.\"ID\"=repromaterijalproizvod.\"tipproizvodaID\" "
                          + " AND repromaterijalproizvod.\"tipproizvodaID\"<>0";
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void unesiProizvod(string naziv, float cijena, string opis, float stanje, string mjera, int tip)
        {
            string sql = string.Format("INSERT INTO repromaterijalproizvod(naziv,cijena,opis,stanje,mjera,\"tipproizvodaID\")"
                            + " VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", naziv,cijena, opis, stanje, mjera, tip);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static void azurirajProizvod(string naziv, float cijena, string opis, float stanje, string mjera, int tip, string id)
        {
            string sql = string.Format("UPDATE repromaterijalproizvod SET naziv='{0}', cijena='{1}', opis='{2}',"
                                        +" stanje='{3}', mjera='{4}', \"tipproizvodaID\"='{5}' WHERE \"ID\"='{6}'", naziv, cijena, opis, stanje, mjera, tip, id);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static void brisiProizvod(string id)
        {
            string sql = string.Format("DELETE FROM repromaterijalproizvod WHERE \"ID\"='{0}'", id);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static NpgsqlDataReader dohvatiRepromaterijaleProizvoda(string id)
        {
            string sql = string.Format("SELECT \"repromaterijalproizvod\".\"ID\", \"repromaterijalproizvod\".naziv, cijena, \"repromaterijalproizvod\".opis, stanje, \"repromaterijalproizvod\".mjera, kolicina "
                        + " FROM \"repromaterijalproizvod\", \"sastavnica\" WHERE \"repromaterijalproizvod\".\"ID\" = \"sastavnica\".\"repromaterijalID\" AND \"sastavnica\".\"proizvodID\" = '{0}'", id);
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void brisiSastavnicuProizvoda(string idProizvoda, string idSastavnice)
        {
            string sql = string.Format("DELETE FROM sastavnica WHERE \"proizvodID\"='{0}' AND \"repromaterijalID\"='{1}'", idProizvoda,idSastavnice);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static NpgsqlDataReader dohvatiRepromaterijaleKojeNemaProizvod(string id)
        {
            string sql = string.Format("SELECT \"repromaterijalproizvod\".\"ID\", \"repromaterijalproizvod\".naziv, cijena, \"repromaterijalproizvod\".opis, stanje, \"repromaterijalproizvod\".mjera, kolicina "
                        + " FROM \"repromaterijalproizvod\", \"sastavnica\" WHERE \"repromaterijalproizvod\".\"ID\" <> \"sastavnica\".\"repromaterijalID\" AND \"sastavnica\".\"proizvodID\" <> '{0}'", id);
            return Baza.Instance.dohvati_podatke(sql);
        }
    }
}
