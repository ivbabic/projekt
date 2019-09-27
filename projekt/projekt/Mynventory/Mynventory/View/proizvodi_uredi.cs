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
    public partial class Proizvodi_uredi : MetroFramework.Forms.MetroForm
    {
        public Proizvodi_uredi()
        {
            InitializeComponent();
        }

        private void Proizvodi_uredi_Load(object sender, EventArgs e)
        {
            DohvatiId();
        }

        private void m_cancel_pro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_ok_pro_Click(object sender, EventArgs e)
        {
            
            
        }

        public void DohvatiId()
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand com = Baza.con.CreateCommand();
            com.CommandText = String.Format(@"SELECT id FROM proizvodi WHERE naziv  = '" + m_naziv.Text + "'");
            var rez = com.ExecuteScalar();
            m_id.Text = rez.ToString();
            com.Dispose();
            Baza.ZatvoriKonekciju();

        }

       

        public void AzurirajProizvod()
        {
            Baza.OtvoriKonekciju();
            SQLiteCommand comm = Baza.con.CreateCommand();
            comm.CommandText = String.Format(@"UPDATE proizvodi SET naziv= '" + m_naziv.Text + "',mjerna_jedinica= '" + c_mj.Text + "', cijena= '" + m_cijena.Text + "', kolicina= '" + m_kolicina.Text + "', porezna_stopa= '" + m_ps.Text + "', dobavljac= '" + m_dobavljac.Text + "' WHERE id = '" + m_id.Text + "'");
            SQLiteDataReader readerP = comm.ExecuteReader();
            comm.Dispose();
            Baza.ZatvoriKonekciju();
        }

        private void m_ok_pro_Click_1(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Proizvod izmijenjen !", "Unos uspješan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AzurirajProizvod();

            this.Close();
            Proizvodi_forma main = new Proizvodi_forma();
            main.Show();
        }
          
    }
}
