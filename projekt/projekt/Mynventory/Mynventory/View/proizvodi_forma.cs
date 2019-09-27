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
    public partial class Proizvodi_forma : MetroFramework.Forms.MetroForm
    {
        public Proizvodi_forma()
        {
            InitializeComponent();
        }

        private void Proizvodi_forma_Load(object sender, EventArgs e)
        {
            var ProizvodiIzBaze = Model.DBpristup.DohvatiProizvode();
            g_proizvodi.Rows.Clear();
            foreach (var novi in ProizvodiIzBaze)
            {

                g_proizvodi.DataSource = ProizvodiIzBaze;


            }
        }

                    

         private void Collection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Model.Proizvodi n in e.NewItems)
                {
                    
                    n.Naziv = "Novi proizvod";
                    n.MjernaJedinica = "Novi proizvod";
                    n.Cijena = 0.0;
                    n.Kolicina = 0;
                    n.PoreznaStopa = 0;
                    n.DatumZadnjeProdaje = DateTime.UtcNow;
                    n.Dobavljac = 0;
                }
            }
        }

        private void Datasource_AddingNew(object sender, AddingNewEventArgs e)
        {

            e.NewObject = new Model.Proizvodi("", "", 0.0, 0, 0, DateTime.UtcNow, 0);
        }

        private void UseriBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void b_dodaj_pro_Click(object sender, EventArgs e)
        {
            this.Close();
            Proizvodi_dodaj main = new Proizvodi_dodaj();
            main.Show();
        }

        private void b_uredi_pro_Click(object sender, EventArgs e)
        {

            
            Proizvodi_uredi main = new Proizvodi_uredi();
            
            main.m_naziv.Text = g_proizvodi.CurrentRow.Cells[0].Value.ToString();
            main.c_mj.Text = g_proizvodi.CurrentRow.Cells[1].Value.ToString();
            main.m_cijena.Text = g_proizvodi.CurrentRow.Cells[2].Value.ToString();
            main.m_kolicina.Text = g_proizvodi.CurrentRow.Cells[3].Value.ToString();
            main.m_ps.Text = g_proizvodi.CurrentRow.Cells[4].Value.ToString();
            main.m_dobavljac.Text = g_proizvodi.CurrentRow.Cells[6].Value.ToString();
            
            main.Show();

            



        }

        private void b_izbrisi_pro_Click(object sender, EventArgs e)
        {
            Proizvodi_izbrisi main = new Proizvodi_izbrisi();

            main.m_naziv.Text = g_proizvodi.CurrentRow.Cells[0].Value.ToString();
            main.c_mj.Text = g_proizvodi.CurrentRow.Cells[1].Value.ToString();
            main.m_cijena.Text = g_proizvodi.CurrentRow.Cells[2].Value.ToString();
            main.m_kolicina.Text = g_proizvodi.CurrentRow.Cells[3].Value.ToString();
            main.m_ps.Text = g_proizvodi.CurrentRow.Cells[4].Value.ToString();
            main.m_dobavljac.Text = g_proizvodi.CurrentRow.Cells[6].Value.ToString();

            main.Show();
        }
    }
}
