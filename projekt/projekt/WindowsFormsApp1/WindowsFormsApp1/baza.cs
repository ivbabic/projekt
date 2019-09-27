using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class baza
    {
        //VARIJABLE ZA KONEKCIJU
        public SQLiteConnection con;
        public SQLiteCommand comm;
        //private SQLiteDataAdapter da;
        public DataSet DS = new DataSet();
        public DataTable DT = new DataTable();
        



        // METODA ZA USPOSTAVU KONEKCIJE

        public void uspostavi_kon()
        {
            con = new SQLiteConnection(@"Data Source=G:\\BAZA\\SQLITE\\DB\\projekt.db;Initial Catalog = projekt;Integrated Security =True");


        }

        // METODA ZA PRIPREMU QUERY-A

        public void izvrsi_query(string upit_txt)
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
// primjer upita za update
/*
 *  uspostavi_kon();
            string upit_txt = "update users set ime='"+ime.Text+"', prezime='"+prezime.Text+"', rola='"+rola_combo.Text+"', tel='"+tel.Text+"', email='"+email.Text+"',password='"+password.Text+"', password2='"+password_2.Text+"' where idusers='"+id.Text+"'";
            izvrsi_query(upit_txt);

            this.Hide();
            user_updated main = new user_updated();
            main.Show();
*/