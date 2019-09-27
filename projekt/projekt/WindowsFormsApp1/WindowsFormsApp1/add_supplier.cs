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
    public partial class Add_supplier : Form
    {
        public Add_supplier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // NAPRAVI FORMU SUPPLIER
           
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UBACIVANJE NOVOG DOBAVLJAČA

            var nova_k = new baza();
            var h = new Home();

            nova_k.uspostavi_kon();

            string upit= "Insert into dobavljaci(idusers, naziv, kontakt) values ('"+h.prijavljen.Text+"','"+dime.Text+"','"+ dcontact.Text+"')";
            nova_k.izvrsi_query(upit);
            this.Hide();
            supplier_created main = new supplier_created();
            main.Show();


            
        }
    }
}
