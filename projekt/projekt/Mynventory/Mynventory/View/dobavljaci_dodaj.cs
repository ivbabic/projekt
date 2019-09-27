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
    public partial class Dobavljaci_dodaj : MetroFramework.Forms.MetroForm
    {
        public List<Dobavljaci> ListaDobavljaca;
        public Dobavljaci_dodaj()
        {
            InitializeComponent();
        }

        private void Dobavljaci_dodaj_Load(object sender, EventArgs e)
        {

        }

        private void m_cancel_dob_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_ok_dob_Click(object sender, EventArgs e)
        {
            ListaDobavljaca = new List<Dobavljaci>();
            Dobavljaci novi = new Dobavljaci(m_nazivd.Text, Int32.Parse(m_teld.Text), m_emaild.Text, m_adresad.Text, m_oibd.Text);
            ListaDobavljaca.Add(novi);

            MetroFramework.MetroMessageBox.Show(this, "Dobavljac kreiran !", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dodaj(novi);

            this.Close();
            Dobavljaci_forma main = new Dobavljaci_forma();
            main.Show();
        }

        private void Dodaj(Dobavljaci novi)
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO dobavljaci (naziv,tel,email,adresa,oib)
				                                VALUES  ('" + m_nazivd.Text + "', '" + m_teld.Text + "', '" + m_emaild.Text + "','" + m_adresad.Text + "', '" + m_oibd.Text + "')");

            com.ExecuteNonQuery();
            com.Dispose();
            Baza.ZatvoriKonekciju();
        }
    }
}
