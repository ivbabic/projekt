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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //provjeri user i pass

            SQLiteConnection con = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");
            con.Open();
            SQLiteDataAdapter dap = new SQLiteDataAdapter("Select * FROM users WHERE ime ='"+ username.Text +"' AND password= '"+ password.Text +"'",con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if(dt.Rows.Count == 1)
                 { 
                    this.Hide();
                    Home main = new Home();
                    main.Show();
                 }
            else
            {
                MessageBox.Show("Krivo uneseni podaci !","Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Clear();
            username.Focus();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
