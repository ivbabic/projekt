using Mynventory.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Mynventory.View
{
    public partial class Racun_forma : MetroFramework.Forms.MetroForm
    {
        public List<Proizvodi> ProizvodiIzBaze = new List<Proizvodi>();
        public DataTable dt = new DataTable();
        public double suma;
        public string BrojRacuna;

        public Racun_forma()
        {
            InitializeComponent();
        }

        private void Racun_Load(object sender, EventArgs e)
        {

            ProizvodiIzBaze = DBpristup.DohvatiProizvode();
            gr_proizvodi.Rows.Clear();
            foreach (var novi in ProizvodiIzBaze)
            {

                gr_proizvodi.DataSource = ProizvodiIzBaze;
               


            }

            dt.Columns.Add("Proizvod", typeof(string));
            dt.Columns.Add("Količina", typeof(Decimal));
            dt.Columns.Add("Porezna Stopa", typeof(Decimal));
            dt.Columns.Add("Ukupna Cijena", typeof(double));

            m_dd.Text = DateTime.Now.ToString("yyyy-MM-dd");
            m_dp.Text = DateTime.Now.ToString("yyyy-MM-dd");



        }

        

        private void m_trazi_TextChanged(object sender, EventArgs e)
        {
            //SEARCH TXTBOX
            gr_proizvodi.DataSource = ProizvodiIzBaze.Where(x => x.Naziv == m_trazi.Text).ToList();
            

        }

        private void m_ocisti_Click(object sender, EventArgs e)
        {
            gr_proizvodi.DataSource = ProizvodiIzBaze;
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {

            suma = 0;
            dt.Rows.Add(m_naziv.Text, m_kzu.Text, m_ps.Text, m_uc.Text);
            g_racun.DataSource = dt;
            m_uc.Clear();
            m_kzu.Clear();
           
            for  (int i = 0; i < g_racun.RowCount-1; i++)

            {

                 suma += double.Parse(g_racun.Rows[i].Cells[3].Value.ToString());

            }
            m_suma.Text = suma.ToString() + " kn";
            


        }

        private void gr_proizvodi_SelectionChanged_1(object sender, EventArgs e)
        {
            m_naziv.Text = gr_proizvodi.CurrentRow.Cells[0].Value.ToString();
            m_kol.Text = gr_proizvodi.CurrentRow.Cells[1].Value.ToString();
            m_cijena.Text = gr_proizvodi.CurrentRow.Cells[2].Value.ToString();
            m_ps.Text = gr_proizvodi.CurrentRow.Cells[3].Value.ToString();
        }

        private void m_kzu_Leave(object sender, EventArgs e)
        {
            if ((Decimal.Parse(m_kzu.Text)) > (Decimal.Parse(m_kol.Text)))
            {

                MetroFramework.MetroMessageBox.Show(this, "Unesena količina nije dostupna !", "Provjeriti zalihe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                m_uc.Text = ((Convert.ToDecimal(m_cijena.Text) * ((Convert.ToDecimal(m_ps.Text)) / 100) * (Convert.ToDecimal(m_kzu.Text))).ToString());
            }
        }

        private void b_izbrisi_Click(object sender, EventArgs e)
        {
            suma = 0;
            g_racun.Rows.RemoveAt(g_racun.CurrentRow.Index);

            for (int i = 0; i < g_racun.RowCount - 1; i++)

            {

                suma += double.Parse(g_racun.Rows[i].Cells[3].Value.ToString());

            }
            m_suma.Text = suma.ToString() + " kn";
        }

        private void m_kreiraj_Click(object sender, EventArgs e)
        {

            Baza.OtvoriKonekciju();
            SpremiRacun();
            DohvatiBrojRacuna();
            SpremiStavke();
            AzurirajProizvode();
            Baza.ZatvoriKonekciju();

            MetroFramework.MetroMessageBox.Show(this, "Račun kreiran !", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);



            this.Close();
            


        }

        private void SpremiRacun()
        {
            SQLiteCommand com1 = Baza.con.CreateCommand();
            DateTime DatumIzdavanja = DateTime.ParseExact(m_dd.Text, "yyyy-MM-dd", null);
            DateTime DatumPlacanja = DateTime.ParseExact(m_dd.Text, "yyyy-MM-dd", null);
            Boolean potvrda = true;
            com1.CommandText = String.Format(@"INSERT INTO racun (datum_izdavanja, datum_placanja, potvrda)
                                                    VALUES ({0}, {1}, {2})", DatumIzdavanja.ToFileTime(), DatumPlacanja.ToFileTime(), potvrda); // vidi za bool, 1/0
            com1.ExecuteNonQuery();
            com1.Dispose();
        }

        private void DohvatiBrojRacuna()
        {

            SQLiteCommand com2 = Baza.con.CreateCommand();
            com2.CommandText = String.Format(@"SELECT * FROM racun ORDER BY broj desc limit 1");
            var rez = com2.ExecuteScalar();
            BrojRacuna = rez.ToString();
            com2.Dispose();
        }
        #region
        private void SpremiStavke()
        {
            SQLiteCommand com3 = Baza.con.CreateCommand();
            for (int i = 0; i < g_racun.RowCount - 1; i++)
            {
                com3.CommandText = String.Format(@"INSERT INTO racun_stavke (broj_racuna, naziv_proizvoda, kolicina, cijena)
                                                    VALUES ({0}, '" + g_racun.Rows[i].Cells[0].Value + "', '" + g_racun.Rows[i].Cells[1].Value + "', '" + g_racun.Rows[i].Cells[3].Value + "')", BrojRacuna);
                com3.ExecuteNonQuery();
                
            }
            com3.Dispose();
            
        }

        private void AzurirajProizvode()
        {
            SQLiteCommand com4 = Baza.con.CreateCommand();
            for (int i = 0; i < g_racun.RowCount - 1; i++)
            {
                com4.CommandText = String.Format(@"UPDATE proizvodi SET kolicina = kolicina - '" + g_racun.Rows[i].Cells[1].Value + "' WHERE naziv = '" + g_racun.Rows[i].Cells[0].Value + "'");
                com4.ExecuteNonQuery();
            }
            com4.Dispose();
        }
        #endregion
        #region
        private void m_uc_Click(object sender, EventArgs e)
        {

        }

        private void m_kol_Click(object sender, EventArgs e)
        {

        }

        private void Lista_pro_Click(object sender, EventArgs e)
        {

        }

        private void Lista_pro_SelectedIndexChanged(object sender, EventArgs e)
        {


        }




        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gr_proizvodi_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion Nepotrebno

        

   
    }
}
