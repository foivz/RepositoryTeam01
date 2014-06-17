using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace PI
{
    class Baza
    {
        private static Baza instance;
        private NpgsqlConnection conn;

        private Baza()
        {
            Konekcija = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=postgres;");
            Konekcija.Open();
        }

        ~Baza()
        {
            Konekcija.Close();
            Konekcija = null;
        }

        public static Baza Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Baza();
                }
                return instance;
            }
        }

        public NpgsqlConnection Konekcija
        {
            get { return conn; }
            private set { conn = value; }
        }

        public NpgsqlDataReader dohvati_podatke(string sql)
        {
            NpgsqlCommand naredba = new NpgsqlCommand(sql, Konekcija);
            return naredba.ExecuteReader();
        }

        public int izvrsi_upit(string sql)
        {
            NpgsqlCommand naredba = new NpgsqlCommand(sql, Konekcija);
            return naredba.ExecuteNonQuery();
        }

        internal NpgsqlDataReader dohvati_osobe(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
