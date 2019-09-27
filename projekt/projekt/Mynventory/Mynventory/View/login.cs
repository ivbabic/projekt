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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            User_txt.Text = "";
            Pass_txt.Clear();
            User_txt.Focus();
        }

        private void User_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Provjeri_login();
            }
        }

        private void Pass_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Provjeri_login();
            }
        }

        private void B_login_Click(object sender, EventArgs e)
        {
            Provjeri_login();
        }

        public void Provjeri_login()
        {
;

            Model.Baza.OtvoriKonekciju();
            SQLiteDataAdapter dap = new SQLiteDataAdapter("Select * FROM users WHERE ime ='" + User_txt.Text + "' AND password= '" + Pass_txt.Text + "'", Model.Baza.con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Hide();
                Glavni main = new Glavni();
                main.Show();

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Krivo uneseni podaci !", "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            Model.Baza.ZatvoriKonekciju();

        }
    }
}
