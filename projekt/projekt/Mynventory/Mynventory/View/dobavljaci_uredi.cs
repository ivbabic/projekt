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
    public partial class Dobavljaci_uredi : MetroFramework.Forms.MetroForm
    {
        public Dobavljaci_uredi()
        {
            InitializeComponent();
        }

        private void Dobavljaci_uredi_Load(object sender, EventArgs e)
        {
            DohvatiId();
        }

        private void m_ok_dob_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Dobavljac izmijenjen !", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AzurirajDobavljac();

            this.Close();
            Dobavljaci_forma main = new Dobavljaci_forma();
            main.Show();
        }

        public void DohvatiId()
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT id FROM dobavljaci WHERE naziv  = '" + m_nazivd.Text + "'");
            var rez = com.ExecuteScalar();
            m_idd.Text = rez.ToString();
            com.Dispose();
            Baza.ZatvoriKonekciju();

        }

        public void AzurirajDobavljac()
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand comm = Baza.con.CreateCommand();
            comm.CommandText = String.Format(@"UPDATE dobavljaci SET naziv= '" + m_nazivd.Text + "',tel= '" + m_teld.Text + "', email= '" + m_emaild.Text + "', adresa= '" + m_adresad.Text + "', oib= '" + m_oibd.Text + "' WHERE id = '" + m_idd.Text + "'");
            SQLiteDataReader readerP = comm.ExecuteReader();
            comm.Dispose();
            Baza.ZatvoriKonekciju();
        }

        private void m_cancel_dob_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
