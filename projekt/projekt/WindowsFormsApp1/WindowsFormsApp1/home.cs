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
    public partial class Home : Form
    {
        public object DataGridView1 { get; internal set; }

        public Home() => InitializeComponent();



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login main = new Login();
            main.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            //this.Hide();
            Add_user main = new Add_user();
            main.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void users_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ucitaj();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ucitaj();
        }

        public void ucitaj()
        {
            //UČITAVANJE NOVOG STANJA KORISNIKA

            SQLiteConnection con = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");
            con.Open();

            SQLiteDataAdapter dap = new SQLiteDataAdapter("SELECT * FROM users", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            dataGridView1.Rows.Clear(); // DA SE SPRIJEČI PONOVNO UPISIVANJE ISTIH USERA U TABLICU
            foreach (DataRow Item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = Item["idusers"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = Item["ime"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = Item["prezime"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = Item["rola"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = Item["tel"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = Item["email"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = Item["password"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = Item["password2"].ToString();  //REORDAJ STUPCE U TABLICI - INDEXI 
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();   -----------PREKO EDIT BUTTONA
            Edit_user main = new Edit_user();
            main.Show();
            main.id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            main.ime.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            main.prezime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            main.rola_combo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            main.tel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            main.email.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            main.password.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            main.password_2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        public void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ucitaj_dob()
        {

            SQLiteConnection conn = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");
            conn.Open();

            //UČITAVANJE NOVOG STANJA DOBAVLJAČA

            SQLiteDataAdapter dapp = new SQLiteDataAdapter("SELECT * FROM dobavljaci", conn);
            DataTable dt2 = new DataTable();
            dapp.Fill(dt2);
            dataGridView2.Rows.Clear(); // DA SE SPRIJEČI PONOVNO UPISIVANJE ISTIH USERA U TABLICU
            foreach (DataRow Item in dt2.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = Item["iddobavljaci"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = Item["idusers"].ToString();
                dataGridView2.Rows[n].Cells[2].Value = Item["naziv"].ToString();
                dataGridView2.Rows[n].Cells[3].Value = Item["kontakt"].ToString();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ucitaj_dob();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            // UČITAJ PODATKE TRENUTNO AKTIVNOG USERA
            var tren_user = new Login();


            SQLiteConnection con = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");
            con.Open();
            string upit_txt = "select idusers, ime from users where ime='" + tren_user.username.Text + "' and password='" + tren_user.password.Text + "'";
            SQLiteCommand comm = con.CreateCommand();
            comm.CommandText = upit_txt;
            comm.ExecuteNonQuery();
            SQLiteDataReader novi = comm.ExecuteReader();
            while (novi.Read())
            {
                prijavljen.Text = novi["idusers"].ToString();
                tren_ime.Text = novi["ime"].ToString();
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //PRIKAŽI DODAJ DOBAVLJAČA

            Add_supplier main = new Add_supplier();
            main.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Edit_supplier main = new Edit_supplier();
            main.Show();
            main.id_d.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            main.naziv_d.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            main.kontakt_d.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            ucitaj_dob();
        }

       
    }
}
