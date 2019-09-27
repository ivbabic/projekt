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
    public partial class Dobavljaci_izbrisi : MetroFramework.Forms.MetroForm
    {
        public Dobavljaci_izbrisi()
        {
            InitializeComponent();
        }

        private void Dobavljaci_izbrisi_Load(object sender, EventArgs e)
        {

        }

        private void l_naziv_Click(object sender, EventArgs e)
        {

        }

        private void l_kolicina_Click(object sender, EventArgs e)
        {

        }

        private void l_cijena_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void m_back_dob_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void m_del_dob_Click(object sender, EventArgs e)
        {


            MetroFramework.MetroMessageBox.Show(this, "Dobavljač izbrisan !", "Zahtjev uspješno izvršen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            IzbrisiDobavljac();

            this.Close();
            Dobavljaci_forma main = new Dobavljaci_forma();
            main.Show();
        }

        public void IzbrisiDobavljac()
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand comm = Baza.con.CreateCommand();
            comm.CommandText = String.Format(@"DELETE from dobavljaci WHERE naziv = '" + m_nazivd.Text + "' AND oib = '" + m_oibd.Text + "'");
            SQLiteDataReader readerP = comm.ExecuteReader();
            comm.Dispose();
            Baza.ZatvoriKonekciju();
        }
    }
}
