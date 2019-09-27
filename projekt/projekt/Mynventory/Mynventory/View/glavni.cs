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
    public partial class Glavni : MetroFramework.Forms.MetroForm
    {
        public Glavni()
        {
            InitializeComponent();
        }

        private void Glavni_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Vrijeme.Text = DateTime.Now.ToLongTimeString();
            Datum.Text = DateTime.Now.ToLongDateString();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Vrijeme.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void Korisnici_Click(object sender, EventArgs e)
        {
            Useri_forma main = new Useri_forma();
            main.Show();
        }

        private void t_proizvodi_Click(object sender, EventArgs e)
        {
            Proizvodi_forma main = new Proizvodi_forma();
            main.Show();
        }

        private void t_dobavljaci_Click(object sender, EventArgs e)
        {
            Dobavljaci_forma main = new Dobavljaci_forma();
            main.Show();
        }

        private void t_racun_Click(object sender, EventArgs e)
        {
            Racun_forma main = new Racun_forma();
            main.Show();
        }

        private void t_transakcije_Click(object sender, EventArgs e)
        {
            Transakcije_forma main = new Transakcije_forma();
            main.Show();
                
           
        }
    }
}
