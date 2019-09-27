using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
    public partial class Useri_forma : MetroFramework.Forms.MetroForm


    {
        

        public Useri_forma()
        {
            InitializeComponent();
        }

        private void Useri_Load(object sender, EventArgs e)
        {

            var UseriIzBaze = Model.DBpristup.DohvatiUsere();
            g_useri.Rows.Clear();
            foreach (var novi in UseriIzBaze)
            {

                g_useri.DataSource = UseriIzBaze;

                
            }
            

        }

        public void Ucitaj()
        {
           
        }

        private void UseriBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void B_uredi_Click(object sender, EventArgs e)
        {
            
        }

        private void B_dodaj_Click(object sender, EventArgs e)
        {
            
            Useri_dodaj main = new Useri_dodaj();
            main.Show();
         
        }

        private void Collection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (Model.Useri n in e.NewItems)
                {
                    n.Ime = "Novi korisnik";
                    n.Prezime = "Novi korisnik";
                    n.Rola = "Novi korisnik";
                    n.Tel = 0;
                    n.Email = "Novi korisnik";
                    n.Password = "Novi korisnik";
                }
            }
        }

        private void Datasource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
            e.NewObject = new Model.Useri("","","",0,"","");
        }

        private void UseriBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void B_osvjezi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
