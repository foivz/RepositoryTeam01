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

        public static void brisiProizvod(string id)
        {
            string sql=string.Format("DELETE FROM tipproizvoda WHERE \"ID\"='{0}'",id);
            Baza.Instance.izvrsi_upit(sql);
        }
    }
}
