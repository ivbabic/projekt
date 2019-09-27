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
    public partial class Edit_user : Form
    {
        
        
        public Edit_user()
        {
            InitializeComponent();
        }

        //VARIJABLE ZA KONEKCIJU
        private SQLiteConnection con;
        private SQLiteCommand comm;
        //private SQLiteDataAdapter da;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();



        public void Edit_user_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       

        private void Edit_user_Enter(object sender, EventArgs e)
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            uspostavi_kon();
            string upit_txt = "update users set ime='"+ime.Text+"', prezime='"+prezime.Text+"', rola='"+rola_combo.Text+"', tel='"+tel.Text+"', email='"+email.Text+"',password='"+password.Text+"', password2='"+password_2.Text+"' where idusers='"+id.Text+"'";
            izvrsi_query(upit_txt);

            this.Hide();
            user_updated main = new user_updated();
            main.Show();
        }

        // METODA ZA USPOSTAVU KONEKCIJE

        private void uspostavi_kon()
        {
            con = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");


        }

        // METODA ZA PRIPREMU QUERY-A

        private void izvrsi_query(string upit_txt)
        {
            uspostavi_kon();
            con.Open();
            comm = con.CreateCommand();
            comm.CommandText = upit_txt;
            comm.ExecuteNonQuery();
            con.Close();
        }
    }
}
