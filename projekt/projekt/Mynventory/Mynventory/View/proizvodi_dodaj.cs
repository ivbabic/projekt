using Mynventory.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mynventory.View
{
    public partial class Proizvodi_dodaj : MetroFramework.Forms.MetroForm
    {
        public List<Model.Proizvodi> ListaProizvoda;

        public Proizvodi_dodaj()
        {
            InitializeComponent();
        }

        private void Proizvodi_dodaj_Load(object sender, EventArgs e)
        {
           
        }

        private void l_ime_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void m_ime_Click(object sender, EventArgs e)
        {

        }

        private void m_ok_Click(object sender, EventArgs e)
        {
            
                ListaProizvoda = new List<Proizvodi>();
                Proizvodi novi = new Proizvodi(m_naziv.Text, c_mj.Text, double.Parse(m_cijena.Text), decimal.Parse(m_kolicina.Text), decimal.Parse(m_ps.Text), DateTime.Parse(m_dzp.Text), int.Parse(m_dobavljac.Text));
                ListaProizvoda.Add(novi);
                
                MetroFramework.MetroMessageBox.Show(this, "Proizvod kreiran !", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dodaj(novi);

                this.Close();
                Proizvodi_forma main = new Proizvodi_forma();
                main.Show();


        }
        


        private void m_cancel_pro_Click(object sender, EventArgs e)
        {
            this.Close();
            Proizvodi_forma main = new Proizvodi_forma();
            main.Show();
        }

        private void Dodaj(Proizvodi novi)
        {
        Baza.OtvoriKonekciju();
        SQLiteCommand com = Baza.con.CreateCommand();
        DateTime Datum = DateTime.ParseExact(m_dzp.Text, "yyyy-MM-dd", null);
        com.CommandText = String.Format(@"INSERT INTO proizvodi (naziv,mjerna_jedinica,cijena,kolicina,porezna_stopa,datum_zadnje_prodaje,dobavljac)
				                                VALUES  ('" + m_naziv.Text + "', '" + c_mj.Text + "', '" + m_cijena.Text + "', '" + m_kolicina.Text + "', '" + m_ps.Text + "', {0}, '" + m_dobavljac.Text + "')", Datum.ToFileTime());

        com.ExecuteNonQuery();
        com.Dispose();
        Baza.ZatvoriKonekciju();
        }

        private void m_dzp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
