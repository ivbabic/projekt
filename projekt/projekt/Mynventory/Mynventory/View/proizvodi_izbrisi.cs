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
    public partial class Proizvodi_izbrisi : MetroFramework.Forms.MetroForm
    {
        public Proizvodi_izbrisi()
        {
            InitializeComponent();
        }

        private void Proizvodi_izbrisi_Load(object sender, EventArgs e)
        {

        }

        private void m_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void m_del_pro_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Proizvod izbrisan !", "Zahtjev uspješno izvršen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            IzbrisiProizvod();

            this.Close();
            Proizvodi_forma main = new Proizvodi_forma();
            main.Show();
            
        }

        public void IzbrisiProizvod()
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand comm = Baza.con.CreateCommand();
            comm.CommandText = String.Format(@"DELETE from proizvodi WHERE naziv = '" + m_naziv.Text + "' AND mjerna_jedinica = '" + c_mj.Text + "'");
            SQLiteDataReader readerP = comm.ExecuteReader();
            comm.Dispose();
            Baza.ZatvoriKonekciju();
        }
    }
}
