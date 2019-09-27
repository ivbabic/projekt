using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Edit_supplier : Form
    {
        public Edit_supplier()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //UREĐIVANJE DOBAVLJAČA

            var k = new baza();
            var n = new Home();

            k.uspostavi_kon();
            string upit_txt = "update dobavljaci set naziv='" + naziv_d.Text + "', kontakt='" + kontakt_d.Text + "', idusers='" + n.prijavljen.Text + "' where iddobavljaci='" + id_d.Text + "'";
            k.izvrsi_query(upit_txt);

            this.Hide();
            supplier_updated main = new supplier_updated();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
