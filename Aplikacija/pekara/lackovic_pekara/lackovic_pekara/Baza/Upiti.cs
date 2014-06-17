﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PI
{
    class Upiti
    {
        #region login
        public static int provjeriLogin(string username, string password)
        {
            NpgsqlDataReader dr;
            string sql = string.Format("SELECT*FROM osoba WHERE username='{0}' AND lozinka='{1}'", username, password);
            dr = Baza.Instance.dohvati_podatke(sql);
            int uspjesno = 0;
            while (dr.Read())
            {
                uspjesno = int.Parse(dr[0].ToString());
            }
            dr.Close();
            dr.Dispose();
            return uspjesno;
        }
        #endregion

        #region tipovi
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
        #endregion

        #region proizvod
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

        #endregion

        #region repromaterijal

        public static NpgsqlDataReader dohvatiRepromaterijal()
        {
            string sql = "SELECT \"repromaterijalproizvod\".\"ID\", \"repromaterijalproizvod\".naziv,  \"repromaterijalproizvod\".opis, stanje, mjera,"
                          + "\"tipproizvoda\".naziv AS tip FROM tipproizvoda,repromaterijalproizvod WHERE tipproizvoda.\"ID\"=repromaterijalproizvod.\"tipproizvodaID\" "
                          + " AND repromaterijalproizvod.\"tipproizvodaID\"=0";
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void azurirajRepromaterijal(string naziv, float cijena, string opis, float stanje, string mjera, int tip, string id)
        {
            string sql = string.Format("UPDATE repromaterijalproizvod SET naziv='{0}', cijena='{1}', opis='{2}',"
                                        + " stanje='{3}', mjera='{4}', \"tipproizvodaID\"='{5}' WHERE \"ID\"='{6}'", naziv, cijena, opis, stanje, mjera, tip, id);
            Baza.Instance.izvrsi_upit(sql);
        }


        public static void brisiRepromaterijal(string id)
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


        /// <summary>
        /// Funkcija koja dohvaca sve repromaterijale koje nema proizvod
        /// </summary>
        /// <param name="id">Id proizvoda za koje zelimo repromaterijale kojih nema</param>
        /// <returns>Sql rezultat</returns>
        public static NpgsqlDataReader dohvatiRepromaterijaleKojeNemaProizvod(string id)
        {
            string sql = string.Format("SELECT \"repromaterijalproizvod\".\"ID\", \"repromaterijalproizvod\".naziv, " +
                                        " \"repromaterijalproizvod\".opis, stanje, \"repromaterijalproizvod\".mjera "
                        + " FROM \"repromaterijalproizvod\" WHERE \"tipproizvodaID\"=0  EXCEPT " +
                            " SELECT \"repromaterijalproizvod\".\"ID\", \"repromaterijalproizvod\".naziv, " +
                                        " \"repromaterijalproizvod\".opis, stanje, \"repromaterijalproizvod\".mjera "
                        + " FROM \"repromaterijalproizvod\",\"sastavnica\" WHERE \"proizvodID\"='{0}' AND \"repromaterijalproizvod\".\"ID\"=\"sastavnica\".\"repromaterijalID\" ", id);
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void dodajRepromaterijal(string proizvodID, string repromaterijalID, string kolicina, string mjera)
        {
            string sql = string.Format("INSERT INTO \"sastavnica\" VALUES('{0}','{1}','{2}','{3}')", proizvodID, repromaterijalID, kolicina, mjera);
            Baza.Instance.izvrsi_upit(sql);
        }

        #endregion

        #region osobe 

        public static NpgsqlDataReader dohvatiOsobe()
        {
            string sql = "SELECT*FROM \"osoba\";";
            return Baza.Instance.dohvati_osobe(sql);
        }

        public static void dodajOsobe(string ime, string prezime, string username, string lozinka, int telefon, string email)
        {
            string sql = string.Format("INSERT INTO \"osoba\"(ime, prezime, username, lozinka, telefon, email) VALUES"
                + " ('{0}','{1}','{2}','{3}','{4}','{5}' )", ime, prezime, username, lozinka, telefon, email);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static void brisiOsobe(string id)
        {
            string sql = string.Format("DELETE FROM \"osoba\" WHERE \"id\"='{0}';", id);
            Baza.Instance.izvrsi_upit(sql);
        }
        # endregion

        #region poslovniPartneri

        public static NpgsqlDataReader dohvatiPoslovnePartnere()
        {
            string sql = "SELECT*FROM \"poslovnipartner\";";
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void dodajPoslovnePartnere(string naziv, string adresa, string kontakt, string dodatno)
        {
            string sql = string.Format("INSERT INTO \"poslovnipartner\"(naziv,adresa,kontakt,dodatno) VALUES" 
                +" ('{0}','{1}','{2}','{3}')", naziv, adresa, kontakt, dodatno);
            Baza.Instance.izvrsi_upit(sql);
        }

        public static void azurirajPoslovnePartnere(string naziv, string adresa, string kontakt, string dodatno, string id)
        {
            string sql = string.Format("UPDATE \"poslovnipartner\" SET naziv='{0}', adresa='{1}', kontakt='{2}', dodatno='{3}' " +
                " WHERE \"id\"= '{4}'", naziv, adresa, kontakt, dodatno, id);
            Baza.Instance.izvrsi_upit(sql);
        } 

        public static void brisiPoslovnePartnere(string id)
        {
            string sql = string.Format("DELETE FROM \"poslovnipartner\" WHERE \"id\"='{0}';",id);
            Baza.Instance.izvrsi_upit(sql);
        }

        #endregion

        #region dokumenti

        public static NpgsqlDataReader dohvatiDokumente(string id)
        {
            string sql = string.Format("SELECT * FROM \"dokument\"  WHERE \"tipdokumentaID\"='{0}'", id);
            return Baza.Instance.dohvati_podatke(sql);
        }

        public static void dodajDokument( string datum, string dodatno, string tipDokumenta, string poslovniPartner,List<string> kolicine, List<string> popusti, List<string> repromaterijali)
        {
            string sql = string.Format("INSERT INTO dokument(datum,\"dodatniOpis\", \"tipdokumentaID\",\"poslovniPartnerID\",\"osobaID\") VALUES" +
                "('{0}','{1}','{2}','{3}','{4}')", datum, dodatno, tipDokumenta, poslovniPartner, Statics.id);
            Baza.Instance.izvrsi_upit(sql);
             sql = "SELECT MAX(\"ID\") FROM dokument";
             NpgsqlDataReader dr = Baza.Instance.dohvati_podatke(sql);
             string zadnjiId = "";
             while (dr.Read())
             {
                 zadnjiId = dr[0].ToString();
             }
             dr.Close();
             dr.Dispose();
             for (int i = 0; i < kolicine.Count; i++)
             {
                 sql = string.Format("INSERT INTO stavka VALUES('{0}','{1}','{2}','{3}')", kolicine[i], popusti[i], zadnjiId, repromaterijali[i]);
                 Baza.Instance.izvrsi_upit(sql);
             }
        }
         
        #endregion



        internal static void dodajOsobe(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            throw new NotImplementedException();
        }

        internal static void dodajOsobe(string p1, string p2, string p3, string p4)
        {
            throw new NotImplementedException();
        }
    }
}
