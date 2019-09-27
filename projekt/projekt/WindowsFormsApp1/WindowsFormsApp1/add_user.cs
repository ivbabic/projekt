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

namespace WindowsFormsApp1
{
    public partial class Add_user : Form
    {
        public Add_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SQLiteConnection con = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");
            //UBACIVANJE NOVOG USERA
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO users(ime, prezime, rola, tel, email, password, password2) VALUES ('"+ ime.Text + "','" + prezime.Text + "', '" + rola_combo.Text + "', '" + tel.Text + "', '" + email.Text + "', '" + password.Text + "', '" + password_2.Text + "' )", con); // za rolu napravi combo box
            if (password.Text != password_2.Text)
            {
                MessageBox.Show("Krivi unos potvrde lozinke", "Pokušaj ponovno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                cmd.ExecuteNonQuery();
                con.Close();


                this.Hide();
                //MessageBox.Show("User created !");  -- samo pop up mali
                user_created main = new user_created();
                main.Show();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Home main = new Home();
           //main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
