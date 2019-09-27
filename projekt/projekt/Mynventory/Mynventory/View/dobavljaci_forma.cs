using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mynventory.View
{
    public partial class Dobavljaci_forma : MetroFramework.Forms.MetroForm
    {
        public Dobavljaci_forma()
        {
            InitializeComponent();
        }

        private void Dobavljaci_forma_Load(object sender, EventArgs e)
        {
            var DobavljaciIzBaze = Model.DBpristup.DohvatiDobavljace();
            g_dobavljaci.Rows.Clear();
            foreach (var novi in DobavljaciIzBaze)
            {

                g_dobavljaci.DataSource = DobavljaciIzBaze;


            }
        }

        private void Collection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Model.Dobavljaci n in e.NewItems)
                {
                    n.Naziv = "Novi Dobavljac";
                    n.Telefon = 0;
                    n.Email = "Novi Dobavljaci";
                    n.Adresa = "Novi Dobavljaci";
                    n.Oib = "Novi Dobavljaci";
                }
            }
        }

        private void Datasource_AddingNew(object sender, AddingNewEventArgs e)
        {

            e.NewObject = new Model.Dobavljaci("", 0, "", "","");
        }

        private void UseriBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void b_uredi_dob_Click(object sender, EventArgs e)
        {
            Dobavljaci_uredi main = new Dobavljaci_uredi();

            main.m_nazivd.Text = g_dobavljaci.CurrentRow.Cells[0].Value.ToString();
            main.m_teld.Text = g_dobavljaci.CurrentRow.Cells[1].Value.ToString();
            main.m_emaild.Text = g_dobavljaci.CurrentRow.Cells[2].Value.ToString();
            main.m_adresad.Text = g_dobavljaci.CurrentRow.Cells[3].Value.ToString();
            main.m_oibd.Text = g_dobavljaci.CurrentRow.Cells[4].Value.ToString();

            main.Show();
        }

        private void b_dodaj_Click(object sender, EventArgs e)
        {
            this.Close();
            Dobavljaci_dodaj main = new Dobavljaci_dodaj();
            main.Show();
        }

        private void b_izbrisi_dob_Click(object sender, EventArgs e)
        {
            Dobavljaci_izbrisi main = new Dobavljaci_izbrisi();

            main.m_nazivd.Text = g_dobavljaci.CurrentRow.Cells[0].Value.ToString();
            main.m_teld.Text = g_dobavljaci.CurrentRow.Cells[1].Value.ToString();
            main.m_emaild.Text = g_dobavljaci.CurrentRow.Cells[2].Value.ToString();
            main.m_adresad.Text = g_dobavljaci.CurrentRow.Cells[3].Value.ToString();
            main.m_oibd.Text = g_dobavljaci.CurrentRow.Cells[4].Value.ToString();

            main.Show();
        }
    }
}
