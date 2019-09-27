using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Mynventory.Model
{
    public class DBpristup
    {
        static DBpristup()
        {
            
        }


        public static List<Useri> DohvatiUsere()
        {
            Baza.OtvoriKonekciju();
            var AktivnaListaUsera = new List<Useri>();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT ime,prezime,rola,tel,email,password FROM users");
            SQLiteDataReader dr = com.ExecuteReader();
            while (dr.Read())

            {
                Useri novi = new Useri
                {
                    Ime = dr[0].ToString(),
                    Prezime = dr[1].ToString(),
                    Rola = dr[2].ToString(),
                    Tel = dr.GetInt32(3),
                    Email = dr[4].ToString(),
                    Password = dr[5].ToString()
                };
                AktivnaListaUsera.Add(novi);
            }
            com.Dispose();
            Baza.ZatvoriKonekciju();
            return AktivnaListaUsera;
        }



        public static List<Proizvodi> DohvatiProizvode()
        {
            Baza.OtvoriKonekciju();
            var AktivnaListaProizvoda = new List<Proizvodi>();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT naziv,mjerna_jedinica,cijena,kolicina,porezna_stopa,datum_zadnje_prodaje,dobavljac FROM proizvodi");
            SQLiteDataReader readerP = com.ExecuteReader();
            while (readerP.Read())
            {
                Proizvodi novi = new Proizvodi
                {
                    Naziv = readerP[0].ToString(),
                    MjernaJedinica = readerP[1].ToString(),
                    Cijena = readerP.GetDouble(2),
                    Kolicina = readerP.GetDecimal(3),
                    PoreznaStopa = readerP.GetDecimal(4),
                    DatumZadnjeProdaje = DateTime.FromFileTime(readerP.GetInt64(5)),
                    Dobavljac = readerP.GetInt32(6)
                };
                AktivnaListaProizvoda.Add(novi);
            }
            com.Dispose();
            Baza.ZatvoriKonekciju();
            return AktivnaListaProizvoda;
        }


        public static List<Dobavljaci> DohvatiDobavljace()
        {
            Baza.OtvoriKonekciju();
            var AktivnaListaDobavljaca = new List<Dobavljaci>();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT naziv,tel, email, adresa, oib FROM dobavljaci");
            SQLiteDataReader readerD = com.ExecuteReader();
            while (readerD.Read())
            {
                Dobavljaci novi = new Dobavljaci
                {
                    Naziv = readerD[0].ToString(),
                    Telefon = readerD.GetInt32(1),
                    Email = readerD[2].ToString(),
                    Adresa = readerD[3].ToString(),
                    Oib = readerD[4].ToString(),
                };
                AktivnaListaDobavljaca.Add(novi);
            }
            com.Dispose();
            Baza.ZatvoriKonekciju();
            return AktivnaListaDobavljaca;
        }

        public static List<Racun> DohvatiRacune()
        {
            Baza.OtvoriKonekciju();
            var AktivnaListaRacuna = new List<Racun>();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT * FROM racun");
            SQLiteDataReader dr = com.ExecuteReader();
            while (dr.Read())

            {
                Racun novi = new Racun
                {
                    Broj = dr.GetInt32(0),
                    DatumIzdavanja = DateTime.FromFileTime(dr.GetInt64(1)),
                    DatumPlacanja = DateTime.FromFileTime(dr.GetInt64(2)),
                    Potvrda = Convert.ToBoolean(dr.GetInt32(3)),
                   
                };
                AktivnaListaRacuna.Add(novi);
            }
            com.Dispose();
            Baza.ZatvoriKonekciju();
            return AktivnaListaRacuna;
        }


        public static List<RacunStavke> DohvatiStavke()
        {
            Baza.OtvoriKonekciju();
            var AktivnaListaStavki = new List<RacunStavke>();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT broj_racuna, naziv_proizvoda, kolicina, cijena FROM racun_stavke");
            SQLiteDataReader dr = com.ExecuteReader();
            while (dr.Read())

            {
                RacunStavke s = new RacunStavke
                {
                    BrojRacuna = dr.GetInt32(0),
                    NazivProizvoda = dr[1].ToString(),
                    Kolicina = dr.GetDecimal(2),
                    Cijena = dr.GetDouble(3),

                };
                AktivnaListaStavki.Add(s);
            }
            com.Dispose();
            Baza.ZatvoriKonekciju();
            return AktivnaListaStavki;
        }




    }
}
