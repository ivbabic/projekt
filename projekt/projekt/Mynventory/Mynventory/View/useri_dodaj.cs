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
    public partial class Useri_dodaj : MetroFramework.Forms.MetroForm
    {
        public List<Model.Useri> ListaUsera;
        


        public Useri_dodaj()
        {
            InitializeComponent();
        }

        private void Useri_dodaj_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {

            if (m_pass.Text != m_pass2.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Lozinke su različite !", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListaUsera = new List<Useri>();
                Useri novi = new Useri(m_ime.Text, m_prezime.Text, m_rola.Text, Int32.Parse(m_tel.Text), m_email.Text, m_pass.Text);
                ListaUsera.Add(novi);

                MetroFramework.MetroMessageBox.Show(this, "Korisnik kreiran !", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dodaj(novi);

                this.Close();
                Useri_forma main = new Useri_forma();
                main.Show();
                

            }



        }

        private void m_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Useri_forma main = new Useri_forma();
            main.Show();
        }

        private void Dodaj(Useri novi)
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO users (ime,prezime,rola,tel,email,password)
				                                VALUES  ('" + m_ime.Text + "', '" + m_prezime.Text + "', '" + m_rola.Text + "', '" + m_tel.Text + "', '" + m_email.Text + "', '" + m_pass.Text + "')");
            com.ExecuteNonQuery();
            com.Dispose();
            Baza.ZatvoriKonekciju();
        }
    }
}
